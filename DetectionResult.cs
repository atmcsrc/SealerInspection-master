using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusAPI.MV;
using LotusAPI;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;

namespace ATMC.App.SealerInspection {
    public class DetectionResult {
        public class SegmentStat : IJsonSerializable {
            public float MeanWidth { get; set; }
            public float StdevWidth { get; set; }
            public bool OK { get; set; } = false;
            public SegmentStat(float average_width,
                float width_stdev) {
                MeanWidth = average_width;
                StdevWidth = width_stdev;
            }

            public void Write(Json node) {
                node["MeanWidth"] = MeanWidth;
                node["StdevWidth"] = StdevWidth;
            }

            public void Read(Json node) {
                throw new NotImplementedException();
            }
        }

        public DateTime Time { get; protected set; } = DateTime.Now;
        public string ModelName { get; set; } = "Unknown";
        public Bitmap ScreenImage { get; set; } = null;
        public double OKThreshold { get; set; } = 0;
        public double OKRate { get { return AccumOKLength / TotalLength; } }

        public bool IsOK {
            get {
                return Images.Count >= NumImage - SkipCount &&
                    ContinuousNGCount < MaxContinuousNGCount &&
                    OKRate > Registry.GetIntValue("OKPercent", 90) / 100.0;
            }
        }
        public List<Mat> Images { get; protected set; } = new List<Mat>();
        public int SkipCount { get; set; } = 0;
        public int NumImage { get; set; } = 0;
        public int TotalInspectionCount => NumImage - SkipCount;
        public int InspectionCount { get; set; } = 0;
        public Mat ModelImage { get; set; } = null;
        public List<SegmentStat> SegmentStats { get; protected set; } = new List<SegmentStat>();
        public double TotalLength { get; set; } = 0;
        public double AccumOKLength { get; set; } = 0;
        public int MaxContinuousNGCount { get; set; } = 0;
        public int ContinuousNGCount { get; protected set; } = 0;
        int m_ngcount = 0;
        public void ReportOKNG(bool ok) {
            if(ok) {
                m_ngcount = 0;
            }
            else {
                m_ngcount++;
                ContinuousNGCount = System.Math.Max(m_ngcount, ContinuousNGCount);
            }
        }

        void SaveImageJPG(String path, Bitmap bmp) {
            using(MemoryStream memory = new MemoryStream()) {
                using(FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite)) {
                    bmp.Save(memory, ImageFormat.Jpeg);
                    byte[] bytes = memory.ToArray();
                    fs.Write(bytes, 0, bytes.Length);
                }
            }
        }

        string TimeString { get { return Time.ToString("yyyy_MM_dd_hh_mm_ss"); } }
        string DateString { get { return Time.ToString("yyyy_MM_dd"); } }
        public string Text { get { return ModelName + "_" + TimeString; } }

        public void Save() {
            //get result diretcory
            var dir = Registry.GetStringValue("ResultDir", "");
            if(dir == null) throw new Exception("Invalid result directory,  please set ResultDir in registry.");
            var total_dir = $"{dir}/{(IsOK ? "TOTAL_OK" : "TOTAL_NG")}/{DateString}/{ModelName}";
            var total_img = $"{total_dir}/{ModelName}_{TimeString}.jpg";

            //save screen shot
            if(!Directory.Exists(total_dir)) Directory.CreateDirectory(total_dir);
            SaveImageJPG($"{total_dir}/{Text}.jpg", ScreenImage);

            //save result
            var result_dir = $"{dir}/{(IsOK ? "OK" : "NG")}/{DateString}/{ModelName}/{Text}";
            if(!Directory.Exists(result_dir)) Directory.CreateDirectory(result_dir);


            bool save_detection_image = Registry.GetBoolValue("SaveDetectionImage", false);
            //save images
            int idx = 0;
            foreach(var img in Images) {
                if((idx % 2) == 1) {
                    if(save_detection_image)
                        img.Save($"{result_dir}/{Text}_{idx / 2}_detection.jpg");
                }
                else img.Save($"{result_dir}/{Text}_{idx / 2}_raw.jpg");
                idx++;
            }
            //save stat
            Json j = new Json();
            j["SegmentStats"].FromArray(SegmentStats.ToArray());
            j["OKRate"] = OKRate;
            j["TotalLength"] = TotalLength;
            j["OKLength"] = AccumOKLength;
            j["Time"] = TimeString;
            j["ModelName"] = ModelName;
            j["IsOK"] = IsOK;
            j.Save($"{result_dir}/{Text}_stats.json");
        }
    }
}
