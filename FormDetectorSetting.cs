using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusAPI;
using LotusAPI.Math;
using LotusAPI.MV;
using LotusAPI.Controls.Graph;
using LotusAPI.Controls;

namespace ATMC.App.SealerInspection
{


    public partial class FormDetectorSetting : Form
    {
        //List of images
        List<Mat> m_camImgs1 = new List<Mat>();
        List<Mat> m_camImgs2 = new List<Mat>();
        List<Mat> crrImgList = null;

        String m_detectorPath = null;

        //List of detector
        List<PathDetectionInfo> m_infos = new List<PathDetectionInfo>();
        PathDetectionInfo m_crrInfo = null;
        float m_lastROIHeight = 0;
        Json m_timing = null;

        PathDetectionInfo.RegionMap m_crrRegionMap = null;

        //Thread procthread = null;
        Mat m_crrImg = null;
        Mat m_vimg = null;
        Mat m_gimg = null;
        Mat m_vizImg = null;
        int m_pntIdx = 0;
        int m_pntIdx1 = 0;
        Series m_graphSerie = null;


        Json m_crrSettingJson = null;


        int m_VizLineWidth = 2;// Registry.GetIntValue("VisualizeLineWidth")


        Point2f toImgPoint(System.Drawing.Point mouse_pos)
        {
            int idx = cbbImages.SelectedIndex;
            if (idx < 0 || idx >= m_camImgs1.Count) return new Point2f(0, 0);
            float imgw = m_camImgs1[idx].Width;
            float imgh = m_camImgs1[idx].Height;
            float scl = System.Math.Min(imgview.Width / imgw, imgview.Height / imgh);
            float xoff = (imgview.Width - imgw * scl) / 2;
            float yoff = (imgview.Height - imgh * scl) / 2;
            return new Point2f((mouse_pos.X - xoff) / scl, (mouse_pos.Y - yoff) / scl);
        }

        Point2f toImgPoint1(System.Drawing.Point mouse_pos)
        {
            int idx = cbbImages.SelectedIndex;
            if (idx < 0 || idx >= m_camImgs1.Count) return new Point2f(0, 0);
            float imgw = m_vizImg.Width;
            float imgh = m_vizImg.Height;
            float scl = System.Math.Min(vizView.Width / imgw, vizView.Height / imgh);
            float xoff = (vizView.Width - imgw * scl) / 2;
            float yoff = (vizView.Height - imgh * scl) / 2;
            return new Point2f((mouse_pos.X - xoff) / scl, (mouse_pos.Y - yoff) / scl);
        }
        Point toImgViewPoint1(Point2f p)
        {
            int idx = cbbImages.SelectedIndex;
            if (idx < 0 || idx >= m_camImgs1.Count) return new Point(0, 0);
            float imgw = m_vizImg.Width;
            float imgh = m_vizImg.Height;
            float scl = System.Math.Min(vizView.Width / imgw, vizView.Height / imgh);
            float xoff = (vizView.Width - imgw * scl) / 2;
            float yoff = (vizView.Height - imgh * scl) / 2;
            return new Point((int)(p.X * scl + xoff), (int)(p.Y * scl + yoff));
        }

        public FormDetectorSetting(String path)
        {
            InitializeComponent();

            m_detectorPath = path;

            m_graphSerie = new Series("Profile", Color.Red, 1.0f, Symbol.Circle);
            graph.Add(m_graphSerie);
            m_crrRegionMap = new PathDetectionInfo.RegionMap();
            lbRegions.Items.Clear();

            imgview.MouseClick += (o, e) =>
            {
                if (m_pntIdx == 0)
                {
                    m_crrRegionMap.ROI.P1 = toImgPoint(e.Location);
                    m_crrRegionMap.ROI.P2 = toImgPoint(e.Location);
                    m_crrRegionMap.ROI.Width = (float)nud_RoiWidth.Value;
                    m_pntIdx = 1;
                }
                else if (m_pntIdx == 1)
                {
                    m_crrRegionMap.ROI.P2 = toImgPoint(e.Location);
                    m_pntIdx = 0;
                    DetectCurrentImage();
                }
            };

            imgview.MouseMove += (o, e) =>
            {
                if (m_pntIdx == 1)
                {
                    m_crrRegionMap.ROI.P2 = toImgPoint(e.Location);
                    m_crrRegionMap.ROI.Width = (float)nud_RoiWidth.Value;
                    m_pntIdx = 1;
                    if (System.Math.Abs(m_crrRegionMap.ROI.Height - m_lastROIHeight) > 4)
                    {
                        DetectCurrentImage();
                        m_lastROIHeight = m_crrRegionMap.ROI.Height;
                    }
                }
            };

            //Img1
            vizView.MouseClick += (o, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (m_pntIdx1 == 0)
                    {
                        m_crrRegionMap.Segment.P1 = toImgPoint1(e.Location);
                        m_pntIdx1 = 1;
                    }
                    else if (m_pntIdx1 == 1)
                    {
                        m_pntIdx1 = 0;
                        m_crrRegionMap.Segment.P2 = toImgPoint1(e.Location);
                        vizView.Invalidate();
                    }
                }
                else if (e.Button == MouseButtons.Middle)
                {
                    //Scan all roi
                    int idx = 0;
                    var p = toImgPoint1(e.Location);
                    foreach (var info in m_infos)
                    {
                        foreach (var roi in info.ROIs)
                        {
                            float x = Math.Min(roi.Segment.P1.X, roi.Segment.P2.X) - 5;
                            float y = Math.Min(roi.Segment.P1.Y, roi.Segment.P2.Y) - 5;
                            float w = Math.Abs(roi.Segment.P1.X - roi.Segment.P2.X) + 10;
                            float h = Math.Abs(roi.Segment.P1.Y - roi.Segment.P2.Y) + 10;
                            var rect = new RectangleF(x, y, w, h);
                            if (rect.Contains(p))
                            {
                                cbbImages.SelectedIndex = idx;
                                return;
                            }
                        }
                        idx++;
                    }
                }
            };

            vizView.MouseMove += (o, e) =>
            {
                if (m_pntIdx1 == 1)
                {
                    m_crrRegionMap.Segment.P2 = toImgPoint1(e.Location);
                    vizView.Invalidate();
                }
            };

            //Paint 
            vizView.Paint += (o, e) =>
            {
                try
                {
                    Font font = new Font("Consolas", 14, FontStyle.Bold);
                    Pen pen1 = new Pen(Color.Lime, m_VizLineWidth);
                    Pen pen2 = new Pen(Color.Red, m_VizLineWidth);
                    int idx = 0;
                    foreach (var info in m_infos)
                    {
                        foreach (var roi in info.ROIs)
                        {
                            e.Graphics.DrawLine(pen1, toImgViewPoint1(roi.Segment.P1), toImgViewPoint1(roi.Segment.P2));
                            string istr = $"{idx++}";
                            //var ibox_size = e.Graphics.MeasureString(istr, font);
                            //e.Graphics.FillRectangle(Brushes.Black, new RectangleF(roi.Segment.P1,ibox_size));
                            e.Graphics.DrawString(istr, font, Brushes.Magenta, toImgViewPoint1(roi.Segment.P1));
                        }
                    }
                    if (m_crrInfo != null)
                    {
                        foreach (var roi in m_crrInfo.ROIs)
                        {
                            e.Graphics.DrawLine(pen2, toImgViewPoint1(roi.Segment.P1), toImgViewPoint1(roi.Segment.P2));
                        }
                    }

                    if (m_crrRegionMap != null && m_crrRegionMap.Segment.Valid)
                    {
                        e.Graphics.DrawLine(pen2, toImgViewPoint1(m_crrRegionMap.Segment.P1), toImgViewPoint1(m_crrRegionMap.Segment.P2));
                    }

                }
                catch (Exception ex)
                {
                    Logger.Error(ex.Message);
                }
            };

            imgview.KeyUp += OnKey;
            vizView.KeyUp += OnKey;
        }

        void AdjustVizLineWidth(int diff)
        {
            m_VizLineWidth += diff;
            if (m_VizLineWidth > 10) m_VizLineWidth = 10;
            if (m_VizLineWidth < 1) m_VizLineWidth = 1;
            Registry.SetValue("VisualizationLineWidth", m_VizLineWidth);
            DetectCurrentImage();
        }
        void OnKey(KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.A: bt_AddROI(null, null); break;
                    case Keys.C: btClearROI_Click(null, null); break;
                    case Keys.U: ckb_Use.Checked = !ckb_Use.Checked; break;
                    case Keys.S: SaveCurrentSetting(); break;
                    case Keys.P: PasteSetting(); break;
                    case Keys.OemMinus: AdjustVizLineWidth(-1); break;
                    case Keys.Oemplus: AdjustVizLineWidth(+1); break;
                    case Keys.NumPad1: case Keys.D1: rbCamera1.Checked = true; break;
                    case Keys.NumPad2: case Keys.D2: rbCamera2.Checked = true; break;
                    case Keys.Right: try { cbbImages.SelectedIndex++; } catch (Exception ex) { } break;
                    case Keys.Left: try { cbbImages.SelectedIndex--; } catch (Exception ex) { } break;
                    case Keys.Escape:
                        m_crrRegionMap = new PathDetectionInfo.RegionMap(); DetectCurrentImage();
                        m_pntIdx = 0;
                        m_pntIdx1 = 0;
                        break;
                }
            }
            catch (Exception) { }
        }

        void SaveCurrentSetting()
        {
            try
            {
                m_crrSettingJson = new Json();
                m_crrInfo.Write(m_crrSettingJson);
            }
            catch (Exception) { }
        }

        void PasteSetting()
        {
            try
            {
                if (m_crrSettingJson != null)
                {
                    m_crrInfo.ReadDetector(m_crrSettingJson);
                    if (m_crrInfo.BlurFilter != null)
                    {
                        cbbBlurType.Text = m_crrInfo.BlurFilter.ToString();
                        pgridBlur.SelectedObject = m_crrInfo.BlurFilter;
                    }
                    if (m_crrInfo.ThresholdFilter != null)
                    {
                        cbbThresholdType.Text = m_crrInfo.ThresholdFilter.ToString();
                        pgridThreshold.SelectedObject = m_crrInfo.ThresholdFilter;
                    }

                    //check if there is any ROI
                    if (m_crrSettingJson.Contains("ROIs"))
                    {
                        var regions = m_crrSettingJson["ROIs"].ToArray<PathDetectionInfo.RegionMap>();
                        if (regions.Length > 0)
                        {
                            Json j = new Json();
                            regions[0].Write(j);
                            m_crrRegionMap.ROI.Read(j["ROI"]);
                            DetectCurrentImage();
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void btLoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                string dir = LotusAPI.Controls.FileDialog.ShowFolderBrowserDialog();
                if (dir == "") return;
                if (!Directory.Exists(dir + "/Camera1")) throw new Exception("No Camera1 directory");
                if (!Directory.Exists(dir + "/Camera2")) throw new Exception("No Camera2 directory");
                LoadImages(0, dir + "/Camera1", true);
                LoadImages(1, dir + "/Camera2", false);
                m_timing = Json.ReadFromFile(dir + "/timing.json");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        int CompareFileName(string f1, String f2)
        {
            FileInfo fi1 = new FileInfo(f1);
            FileInfo fi2 = new FileInfo(f2);
            string n1 = fi1.Name.Split('.')[0].Split('_')[1];
            string n2 = fi2.Name.Split('.')[0].Split('_')[1];
            return int.Parse(n1) - int.Parse(n2);
        }

        private void LoadImages(int camid, string dir, bool addcbb)
        {
            try
            {
                var imgList = camid == 0 ? m_camImgs1 : m_camImgs2;
                if (dir != "")
                {
                    var files = Directory.GetFiles(dir);
                    if (addcbb) cbbImages.Items.Clear();
                    imgList.Clear();
                    m_infos.Clear();
                    if (addcbb == false && files.Length != cbbImages.Items.Count)
                    {
                        MessageBox.Show("Number of images does not match.");
                    }
                    int imgidx = 1;
                    //sort files
                    Array.Sort(files, (f1, f2) => CompareFileName(f1, f2));
                    cbbImages.Enabled = false;
                    foreach (var file in files)
                    {
                        if (addcbb) cbbImages.Items.Add("Image_" + imgidx);
                        imgList.Add(Mat.FromFile(file));
                        m_infos.Add(new PathDetectionInfo());
                        imgidx++;
                    }
                    cbbImages.Enabled = true;
                    if (m_camImgs1.Count == m_camImgs2.Count && imgList.Count > 0)
                    {
                        cbbImages.SelectedIndex = 0;
                        cbbImages_SelectedIndexChanged(null, null);
                    }
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void cbbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                m_crrRegionMap = new PathDetectionInfo.RegionMap();

                int idx = cbbImages.SelectedIndex;
                if (IndexIsValid(idx) == false) return;

                lblImgIdx.Text = (cbbImages.SelectedIndex + 1) + "/" + (cbbImages.Items.Count);

                m_crrInfo = m_infos[idx];

                if (m_crrInfo.BlurFilter == null) cbbBlurType.Text = "Default";
                if (m_crrInfo.ThresholdFilter == null) cbbThresholdType.Text = "Default";
                pgridBlur.SelectedObject = m_crrInfo.BlurFilter;
                pgridThreshold.SelectedObject = m_crrInfo.ThresholdFilter;

                pgrid.SelectedObject = m_crrInfo.Detector;
                lbRegions.Items.Clear();
                if (m_crrInfo.ROIs.Count == 0)
                {
                    m_crrInfo.Camera = rbCamera1.Checked ? PathDetectionInfo.CameraSource.Camera1 :
                        PathDetectionInfo.CameraSource.Camera2;
                }
                if (m_crrInfo.Camera == PathDetectionInfo.CameraSource.Camera1)
                {
                    rbCamera1.Checked = true;
                    crrImgList = m_camImgs1;
                }
                else
                {
                    rbCamera2.Checked = true;
                    crrImgList = m_camImgs2;
                }
                if (m_crrInfo.ROIs.Count > 0)
                {
                    nud_RoiWidth.Value = (decimal)m_crrInfo.ROIs[0].ROI.Width;
                    nud_WidthThresholdLower.Value = (decimal)m_crrInfo.ROIs[0].ThresholdLower;
                    nud_WidthThresholdUpper.Value = (decimal)m_crrInfo.ROIs[0].ThresholdUpper;
                    nud_OKThreshold.Value = (decimal)m_crrInfo.ROIs[0].OKThreshold;
                }
                foreach (var roi in m_crrInfo.ROIs) lbRegions.Items.Add(roi.ToString());

                ckb_Use.Checked = !m_crrInfo.Skip;
                panel1.Enabled = ckb_Use.Checked;

                m_crrImg = crrImgList[idx];
                m_vimg = (Mat)m_crrImg.Clone();
                m_gimg = m_vimg.ToGray();
                vizView.Invalidate();
                DetectCurrentImage();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }
        bool IndexIsValid(int idx)
        {
            if (idx < 0 || idx >= m_camImgs1.Count)
            {
                MessageBox.Show("Image index out of bound");
                return false;
            }
            if (idx < 0 || idx >= m_camImgs1.Count)
            {
                MessageBox.Show("Image index out of bound");
                return false;
            }
            return true;
        }

        void DetectCurrentImage()
        {
            try
            {
                int idx = cbbImages.SelectedIndex;
                if (IndexIsValid(idx) == false) return;
                TicToc tt = new TicToc();
                m_vimg = (Mat)m_crrImg.Clone();
                List<RectangleRegion> rois = new List<RectangleRegion>();
                foreach (var map in m_crrInfo.ROIs) rois.Add(map.ROI);
                if (m_crrRegionMap.ROIValid) { rois.Add(m_crrRegionMap.ROI); }
                var segss = m_crrInfo.Detector.Apply(m_gimg, rois.ToArray(), m_vimg);

                m_graphSerie.Clear();
                lbResult.Items.Clear();
                lbResult.BeginUpdate();
                lbResult.Items.Clear();
                float x = 0;
                foreach (var segs in segss)
                {
                    lbResult.Items.Add($"ROI_{x}");
                    lbResult.Items.Add($"AVG(평균값)={segs.Average(seg => seg.Length)}");
                    lbResult.Items.Add($"MIN(최소값)={segs.Min(seg => seg.Length)}");
                    lbResult.Items.Add($"MAX(최대값)={segs.Max(seg => seg.Length)}");

                    foreach (var seg in segs)
                    {
                        //lbResult.Items.Add(System.Math.Round(seg.Position, 2) + ", " + System.Math.Round(seg.Length, 2));
                        m_graphSerie.Add(x + seg.Position, seg.Length);
                    }
                    lbResult.Items.Add("--------------");
                    x += 1;
                }
                lbResult.EndUpdate();

                graph.AutoScaleAxes();
                //detector.Apply(gimg,, vimg);
                //foreach(var region in regionList) {
                //    lb_Result.Items.Add("Region_" + (region_id++));
                //    var result = detector.Detect(gimg, region.P1, region.P2, vimg);
                //    foreach(var res in result) {
                //        lb_Result.Items.Add((res.Right - res.Left) + ", " + res.Position);
                //    }
                //}
                //detector.Detect(gimg, p1, p2, vimg);
                //tt.Tic();
                imgview.SetImage(m_vimg);
                vizView.Invalidate();
                //Logger.Debug("Display: " + tt);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            GC.Collect();
        }

        private void bt_ChangeImgIdx_Click(object sender, EventArgs e)
        {
            try
            {
                if ((LotusAPI.Controls.Button)sender == bt_FirstImg) cbbImages.SelectedIndex = 0;
                else if ((LotusAPI.Controls.Button)sender == bt_LastImg) cbbImages.SelectedIndex = cbbImages.Items.Count - 1;
                else if ((LotusAPI.Controls.Button)sender == bt_PrevImg && cbbImages.SelectedIndex > 0) cbbImages.SelectedIndex = cbbImages.SelectedIndex - 1;
                else if ((LotusAPI.Controls.Button)sender == bt_NextImg && cbbImages.SelectedIndex < cbbImages.Items.Count - 1) cbbImages.SelectedIndex = cbbImages.SelectedIndex + 1;
            }
            catch (Exception ex) { }
        }

        private void nud_RoiWidth_ValueChanged(object sender, EventArgs e)
        {
            m_crrRegionMap.ROI.Width = (float)nud_RoiWidth.Value;
            DetectCurrentImage();
        }

        private void pgrid_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            DetectCurrentImage();
        }

        private void bt_AddROI(object sender, EventArgs e)
        {
            try
            {
                if (m_crrRegionMap.Valid)
                {
                    m_crrRegionMap.ThresholdLower = (float)nud_WidthThresholdLower.Value;
                    m_crrRegionMap.ThresholdUpper = (float)nud_WidthThresholdUpper.Value;
                    m_crrInfo.Camera = rbCamera1.Checked ? PathDetectionInfo.CameraSource.Camera1 :
                         PathDetectionInfo.CameraSource.Camera2;
                    m_crrInfo.ROIs.Add(m_crrRegionMap);
                    var txt = $"{m_crrRegionMap.ToString()}({m_crrRegionMap.ThresholdLower}->{m_crrRegionMap.ThresholdUpper})";
                    lbRegions.Items.Add(txt);
                    Logger.Debug("Added region: " + txt);
                    m_crrRegionMap = new PathDetectionInfo.RegionMap();
                    DetectCurrentImage();
                }
                vizView.Invalidate();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btClearROI_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear confirmation",
                "Are you sure you want to clear this list?",
                MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {
                m_crrInfo.ROIs.Clear();
                lbRegions.Items.Clear();
                DetectCurrentImage();
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (m_infos == null || m_infos.Count == 0) throw new Exception("Nothing to save.");
                string filename = m_detectorPath;
                if (filename == null) filename = LotusAPI.Controls.FileDialog.ShowSaveJsonFileDialog("SaveConfigJson");
                if (filename == "") return;

                //save image
                FileInfo fileinfo = new FileInfo(filename);
                string dir = fileinfo.DirectoryName;
                m_vizImg.Save(dir + "/image.jpg");
                //save timing
                m_timing.Save(dir + "/timing.json");

                Json j = new Json();
                j.FromArray(m_infos.ToArray());
                j.Save(filename);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btLoadConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbImages.Items.Count == 0) throw new Exception("No images. Please load images first.");
                string filename = m_detectorPath;
                if (filename == null) filename = LotusAPI.Controls.FileDialog.ShowOpenJsonFileDialog("LoadConfigJson");
                if (filename == "") return;
                Json j = Json.ReadFromFile(filename);
                if (!j.IsArray) throw new Exception("Invalid setting file (not array)");
                if (j.Count != m_camImgs1.Count) throw new Exception("Invalid setting file (node count != image count)");
                m_infos.Clear();
                m_infos.AddRange(j.ToArray<PathDetectionInfo>());
                cbbImages.SelectedIndex = 0;
                cbbImages_SelectedIndexChanged(null, null);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void btLoadVIsualizeImage_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = LotusAPI.Controls.FileDialog.ShowOpenImageFileDialog("LoadVisualizeImage");
                if (filename == "") return;
                m_vizImg = Mat.FromFile(filename);
                vizView.SetImage(m_vizImg);
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void rbCamera1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCamera1.Checked) m_crrInfo.Camera = PathDetectionInfo.CameraSource.Camera1;
            else m_crrInfo.Camera = PathDetectionInfo.CameraSource.Camera2;
            cbbImages_SelectedIndexChanged(null, null);
        }


        private void cbbThresholdType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_crrInfo != null)
            {
                m_crrInfo.SetThresholdFilter(cbbThresholdType.Items[cbbThresholdType.SelectedIndex].ToString());
                pgridThreshold.SelectedObject = m_crrInfo.ThresholdFilter;
                DetectCurrentImage();
            }
        }

        private void cbbBlurType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (m_crrInfo != null)
            {
                m_crrInfo.SetBlurFilter(cbbBlurType.Items[cbbBlurType.SelectedIndex].ToString());
                pgridBlur.SelectedObject = m_crrInfo.BlurFilter;
                DetectCurrentImage();
            }
        }

        private void nud_Threshold_ValueChanged(object sender, EventArgs e)
        {
            m_crrRegionMap.ThresholdLower = (float)nud_WidthThresholdLower.Value;
            m_crrRegionMap.ThresholdUpper = (float)nud_WidthThresholdUpper.Value;
            DetectCurrentImage();
        }

        private void ckb_Skip_CheckedChanged(object sender, EventArgs e)
        {
            if (m_crrInfo != null)
            {
                m_crrInfo.Skip = !ckb_Use.Checked;
                panel1.Enabled = ckb_Use.Checked;
            }
        }

        private void cbbImages_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int idx = cbbImages.Items.IndexOf(cbbImages.Text);
                    if (idx >= 0 && idx < cbbImages.Items.Count)
                    {
                        cbbImages.SelectedIndex = idx;
                    }
                }
                catch (Exception) { }
            }
        }

        private void linearLayout5_Load(object sender, EventArgs e)
        {

        }

        private void pgrid_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btLoadConfig_Load(object sender, EventArgs e)
        {

        }

        private void btSaveConfig_Load(object sender, EventArgs e)
        {

        }

        private void btLoadImage_Load(object sender, EventArgs e)
        {

        }
    }
}
