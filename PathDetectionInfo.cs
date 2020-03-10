using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusAPI;
using LotusAPI.MV;
using LotusAPI.Math;

namespace ATMC.App.SealerInspection
{
    public class PathDetectionInfo : IJsonSerializable
    {
        //! Visualization segment
        public class VisualizationSegment : IJsonSerializable
        {
            public LotusAPI.Math.Point2f P1 { get; set; } = new Point2f(0, 0);
            public LotusAPI.Math.Point2f P2 { get; set; } = new Point2f(0, 0);
            public bool Valid { get { return P1.X > 0 && P2.X > 0; } }

            public void Read(Json node)
            {
                Point2f p = new Point2f();
                p.Read(node["P1"]);
                P1 = p;
                p.Read(node["P2"]);
                P2 = p;
            }

            public void Write(Json node)
            {
                P1.Write(node["P1"]);
                P2.Write(node["P2"]);
            }
        };

        public class RegionMap : IJsonSerializable
        {
            public RectangleRegion ROI { get; set; } = new RectangleRegion();
            public VisualizationSegment Segment { get; set; } = new VisualizationSegment();
            public float ThresholdLower { get; set; } = 10;
            public float ThresholdUpper{ get; set; } = 100;
            public bool Valid { get { return Segment.Valid && ROIValid; } }
            public bool ROIValid { get { return ROI.Height > 20; } }
            public int OKThreshold{ get; set; } = 90;
            public void Read(Json node)
            {
                ROI.Read(node["ROI"]);
                Segment.Read(node["Segment"]);
                OKThreshold= node["OKThreshold"].GetInt(90);
                ThresholdLower = node["ThresholdLower"].GetFloat(20.0f);
                ThresholdUpper= node["ThresholdUpper"].GetFloat(100.0f);
            }
            public void Write(Json node)
            {
                ROI.Write(node["ROI"]);
                Segment.Write(node["Segment"]);
                node["OKThreshold"] = OKThreshold;
                node["ThresholdLower"] = ThresholdLower;
                node["ThresholdUpper"] = ThresholdUpper;
            }
        }
        public enum CameraSource
        {
            Camera1,
            Camera2
        };

        public PathDetector Detector { get; set; } = new PathDetector();
        public IImageFilter BlurFilter { get; set; } = null;
        public IImageFilter ThresholdFilter { get; set; } = null;
        public List<RegionMap> ROIs { get; set; } = new List<RegionMap>();
        public CameraSource Camera { get; set; } = CameraSource.Camera1;

        public bool Skip { get; set; } = true;

        IImageFilter[] BlurFilters = new IImageFilter[] {
            new LotusAPI.MV.BoxFilter(),
            new LotusAPI.MV.GaussianFilter(),
            new LotusAPI.MV.MedianFilter(),
        };

        IImageFilter[] ThresholdFilters = new IImageFilter[] {
            new LotusAPI.MV.BinaryThresholdFilter(),
            new LotusAPI.MV.GaussianAdaptiveThresholdFilter(),
            new LotusAPI.MV.MeanAdaptiveThresholdFilter(),
            new LotusAPI.MV.LocalAverageAdaptiveThresholdFilter(),
            new LotusAPI.MV.OtsuThresholdFilter(),
            new LotusAPI.MV.TriangleThresholdFilter(),
        };


        public void SetBlurFilter(string classname)
        {
            BlurFilter = Array.Find<IImageFilter>(BlurFilters, x => x.GetType().FullName == classname);
            if (BlurFilter != null) Detector.SetBlurFilter(BlurFilter);
        }

        public void SetThresholdFilter(string classname)
        {
            ThresholdFilter = Array.Find<IImageFilter>(ThresholdFilters, x => x.GetType().FullName == classname);
            if (ThresholdFilter != null) Detector.SetThresholdFilter(ThresholdFilter);
        }

        public void ReadDetector(Json node)
        {
            Detector.Read(node["Detector"]);
            Skip = node["Skip"].GetBool(false);
            if (node.Contains("BlurFilter"))
            {
                var j = node["BlurFilter"];
                SetBlurFilter(j["Type"].GetString(typeof(LotusAPI.MV.BlurFilter).FullName));
                if (BlurFilter != null) ((IJsonSerializable)BlurFilter).Read(j["Config"]);
            }
            if (node.Contains("ThresholdFilter"))
            {
                var j = node["ThresholdFilter"];
                SetThresholdFilter(j["Type"].GetString(typeof(LotusAPI.MV.BinaryThresholdFilter).FullName));
                if (ThresholdFilter!= null) ((IJsonSerializable)ThresholdFilter).Read(j["Config"]);
            }
        }

        public void Read(Json node)
        {
            ReadDetector(node);
            ROIs.Clear();
            ROIs.AddRange(node["ROIs"].ToArray<RegionMap>());
            Camera = (CameraSource)Enum.Parse(typeof(CameraSource), (string)node["Source"]);
        }

        public void Write(Json node)
        {
            Detector.Write(node["Detector"]);
            node["Skip"] = Skip;
            if (BlurFilter != null)
            {
                var j = node["BlurFilter"];
                j["Type"] = BlurFilter.GetType().FullName;
                ((IJsonSerializable)BlurFilter).Write(j["Config"]);
            }
            if (ThresholdFilter != null)
            {
                var j = node["ThresholdFilter"];
                j["Type"] = ThresholdFilter.GetType().FullName;
                ((IJsonSerializable)ThresholdFilter).Write(j["Config"]);
            }
            node["ROIs"].FromArray(ROIs.ToArray());
            node["Source"] = Camera.ToString();
        }
    }
}
