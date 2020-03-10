using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMC.Controls;
using ATMC.HW;
using LotusAPI;
using LotusAPI.Controls;
using LotusAPI.Math;
using LotusAPI.MV;
using LotusAPI.HW;
using System.IO;

//TODO: 1. Camera connection
//TODO: 2. 


namespace ATMC.App.SealerInspection {
    public partial class FormMain : Form {
        #region VARS
        FormSetting m_formSetting = new FormSetting();
        //IO card
        //AdvantechDaq m_daq = new AdvantechDaq();
        //Camera
        //CameraDevice m_cam1 = null, m_cam2 = null;

        MultiCameraCaptureThread m_capthread = null;
        List<Mat> m_imgList1 = new List<Mat>();
        List<Mat> m_imgList2 = new List<Mat>();
        List<double> m_timingList = new List<double>();
        List<string> m_filenames = new List<string>();
        DetectionResult m_crrResult = null;
        bool m_isTestMode = false;
        double m_start_time = 0;
        //List<ModelConfig> m_modelConfigs = new List<ModelConfig>();
        ModelConfig m_crrModelConfig = null;
        Mat m_crrModelImg = null;
        LotusAPI.Controls.Graph.Series m_crrProfile = new LotusAPI.Controls.Graph.Series("Width", Color.Lime, 2, LotusAPI.Controls.Graph.Symbol.FilledCircle);

        bool m_visionInspecting = false;
        bool m_inspectionStarted = false;
        bool m_waitForFirstTRSignal = false;
        int m_maxTimingErrorMs = 10;

        #endregion

        void ResetStat() { }
        void ResetCounters() {
            resultCounter.OKCount = 0;
            resultCounter.NGCount = 0;
        }

        void ClearImageList() {
            m_imgList1.Clear();
            m_imgList2.Clear();
            m_filenames.Clear();
            m_timingList.Clear();
        }
        void AddImageToList(Mat img1, Mat img2, double time) {
            if(m_isTestMode == false) return;
            m_filenames.Add($"img_{(int)(time - m_start_time)}.png");
            m_imgList1.Add(img1);
            m_imgList2.Add(img2);
            m_timingList.Add(time - m_start_time);
        }

        #region INIT

        public FormMain() {
            InitializeComponent();

            //Init LotusAPI
            Logger.Add(new LogViewLogger(logView));
            logView.ShowDateTime = true;
            Logger.Add(new LotusAPI.FileLogger(Registry.GetStringValue("ResultDir", "C:")
                + $"/LOG/log_{DateTime.Now.ToString("yyyy_MM_dd")}.txt"));
            Library.Initialize();

            //Init other
            InitGUITheme();
            InitGraphView();
            InitIOCards();
            InitController();
            InitCameras();
            InitDetectorConfigs();

            ResetCounters();

            //Set initial state for auto/manual button
            btSetting.Enabled = false;
            btAutoManual.State = true;

            //reset timer
            Global.Instance.OnResetTimer += () => { ResetCounters(); };


            //reinit 
            m_formSetting.ReinitEvent += (o_, e_) => { InitDetectorConfigs(); };
        }


        void InitController() {
            if(Registry.GetStringValue("IOMethod", "None") == "Controller") {
                Global.Instance.ControllerServer.LoadMap();
                //Controller server
                Global.Instance.ControllerServer.OnClientDisconnected += () => { lbl_ServerIP.ContentBackColor = Color.Red; };
                Global.Instance.ControllerServer.OnClientConnected += (ip) => { lbl_ServerIP.ContentBackColor = Color.Lime; lbl_ServerIP.Text = ip; };
                Global.Instance.ControllerServer.OnServerStarted += () => { lbl_ServerIP.ContentBackColor = Color.Yellow; };
                Global.Instance.ControllerServer.OnCommandReceived += OnControllerCommand;
                //start server
                Global.StartControllerServer();
            }
        }

        void InitGUITheme() {
            Color AppBGColor = Color.FromArgb(52, 99, 155);
            Color ButtonBGColor = Color.FromArgb(82, 210, 87);
            Color ItemBGColor = Color.FromArgb(32, 79, 145);
            Color LabelBGColor = Color.FromArgb(33, 49, 90);
            Color DaqItemBGColor = LabelBGColor;// Color.FromArgb(22, 69, 135);
            Color AppTextColor = Color.White;
            Color ItemTextColor = Color.White;
            Color RtcBGColor = Color.FromArgb(39, 80, 36);


            //Color ItemBorderColor = Color.MidnightBlue;

            BackColor = AppBGColor;

            //resultCounter.NumberTextColor =
            //systemMemoryView1.ForeColor =
            modelName.ContentTextColor =
            //realtimeClockView1.ForeColor =
            modelName.LabelTextColor =
            robotName.LabelTextColor =
            daqView.ItemTextColor =
            resultCounter.TotalLabel.ContentForeColor =
            ItemTextColor;

            resultCounter.OKLabel.ForeColor =
            currentResult.ContentForeColor =
            resultCounter.NGLabel.ForeColor = Color.Navy;

            resultCounter.NumberColor =
            modelName.ContentColor =
            robotName.ContentColor =
            //realtimeClockView1.ContentBackColor =
            graphProfile.BackColor =
            logView.BackColor =
            //systemMemoryView1.ContentBackColor =
            imgVisualize.BackColor =
            imgCurrent.BackColor =
            layoutRecentResult.BackColor =
            daqView.BackColor =
                ItemBGColor;

            resultCounter.TotalLabel.ContentBackColor =
            robotName.LabelColor =
            modelName.LabelColor = LabelBGColor;

            daqView.ItemColor = DaqItemBGColor;


            logView.ColorDebug =
            logView.ColorTrace = Color.Silver;
            logView.ColorError = Color.Tomato;
            logView.ColorFatal = Color.Magenta;
            logView.ColorInfo = Color.SkyBlue;
            logView.ColorWarning = Color.Yellow;
            logView.ColorDateTime = Color.Teal;

            graphProfile.Xaxis.Color =
            graphProfile.Xaxis.GridColor =
            graphProfile.Yaxis.Color =
            graphProfile.ForeColor =
            graphProfile.Color = ItemTextColor;

            graphProfile.Yaxis.GridColor = Color.Gray;

            graphProfile.Xaxis.NumberFont =
            graphProfile.Yaxis.NumberFont = new Font("Consolas", 8);

            Invalidate();
        }
        //! Graph view initialization
        void InitGraphView() {
            //Graph view
            graphProfile.Text = "Profile";
            graphProfile.Xaxis.Text = "Position";
            graphProfile.Xaxis.MinorTickCount = 5;
            graphProfile.Xaxis.Font = new Font("Consolas", 11, FontStyle.Bold);
            graphProfile.Yaxis.Text = "Width (pixel)";
            graphProfile.Yaxis.MinorTickCount = 5;
            graphProfile.Yaxis.Font = new Font("Consolas", 11, FontStyle.Bold);
            graphProfile.Add(m_crrProfile);
            m_crrProfile.SymbolSize = 2;
        }

        //! IO card initialization
        void InitIOCards() {
            //init daq view
            try {
                var daq = Global.Instance.DAQ;
                if(Registry.GetStringValue("IOMethod", "None") == "DAQ") {
                    //connect to card
                    daq.Connect(Registry.GetIntValue("IOCardDeviceID", 1));
                    daq.DIOPinStateChanged += OnDIOChanged;

                    //try read io maps
                    var iomapfile = Registry.GetStringValue("IOMapFile", "");
                    if(iomapfile == "") throw new Exception("Registry value does not exist: IOMapFile");
                    Json j = Json.ReadFromFile(iomapfile);
                    daq.PinMap.Read(j["DIOMap"]);

                    daqView.Init(daq);
                    daq.PollRate = Registry.GetIntValue("DaqPollRate", 100);
                    daq.StartPolling();
                }
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        //! INiti detector configuration
        void InitDetectorConfigs() {
            //read file 
            try {
                var models = Global.Instance.Models;
                Logger.Debug("Reading detector config...");
                var all_model_file = Registry.GetStringValue("AllModelFile", "");
                if(all_model_file == "") throw new Exception("Invalid AllModelFile content in registry.");
                //read model configs
                models.Clear();
                var j = Json.ReadFromFile(all_model_file);
                models.AddRange(j.ToArray<ModelConfig>());
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        void PauseCaptureThread() {
            if(m_capthread == null) return;
            try {
                m_capthread.Pause();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }
        void ResumeCaptureThread() { SpawnCaptureThread(); }
        void SpawnCaptureThread() {
            var cam1 = Global.Instance.Cam1;
            var cam2 = Global.Instance.Cam2;
            if((cam1.IsConnected && cam2.IsConnected) == false) throw new Exception("Camera connection failed");
            if(m_capthread != null) return;
            m_capthread = new MultiCameraCaptureThread(new CameraDevice[] { cam1, cam2 });
            m_capthread.CaptureFPS = Registry.GetIntValue("CaptureFPS", 5);
            m_capthread.Start();
            m_capthread.ImageReceived += (imgs, frame_id, time) => {

                if(m_visionInspecting) {
                    OnInspectionImageReceived(imgs, time);
                }
                else {
                    if(imgs[0].IsEmpty || imgs[1].IsEmpty) return;
                    //convert color
                    imgs[0].ConvertToBGR();
                    imgs[1].ConvertToBGR();
                    //draw camera index
                    imgs[0].DrawRasterText("Camera1",
                Mat.RasterFontID.Iosevka28,
                new Point(5, imgs[0].Height - 30),
                Color.Lime, Color.Black);
                    imgs[1].DrawRasterText("Camera1",
                        Mat.RasterFontID.Iosevka28,
                        new Point(5, imgs[1].Height - 30),
                        Color.Lime, Color.Black);
                    imgCurrent.SetImage(imgs[0]);
                }
            };
        }
        //! Camera initializaton
        void InitCameras() {
            try {
                DisconnectAll();

                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                cam1 = new CameraDevice(CameraType.BaslerGigECam);
                cam2 = new CameraDevice(CameraType.BaslerGigECam);
                var filename = Registry.GetStringValue("CameraSettingFile", "");

                CameraUtils.ConnectCameraFromFile(ref Global.Instance.Cam1,
                    ref Global.Instance.Cam2,
                    filename);

                SpawnCaptureThread();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        #endregion


        void OnInspectionImageReceived(List<Mat> imgs, double time) {
            if(m_inspectionStarted == false) {
                m_start_time = time;
                m_inspectionStarted = true;
            }


            AddImageToList(imgs[0], imgs[1], time);

            //If we are in testing mode, dont inspect
            if(m_isTestMode) return;

            double t = time - m_start_time;
            //Logger.Debug($"T={t}");
            //look for detector id
            PathDetectionInfo crrInfo = null;
            int detector_idx = 0;
            for(int i = 0; i < m_crrModelConfig.Timing.Count; i++) {
                if(Math.Abs(t - m_crrModelConfig.Timing[i]) < m_maxTimingErrorMs) {
                    detector_idx = i;
                    crrInfo = m_crrModelConfig.Detectors[i];
                    break;
                }
            }
            //if reach end of path, stop detetion by setting robot started to false
            if(detector_idx >= m_crrModelConfig.Detectors.Count - 1) {
                m_visionInspecting = false;
            }
            if(crrInfo == null) {
                Logger.Error($"Cant find proper detector for t={t}ms");
            }
            else {
                //If current image should be skipped?
                if(crrInfo.Skip) return;

                var img = crrInfo.Camera == PathDetectionInfo.CameraSource.Camera1 ? imgs[0] : imgs[1];
                var vimg = img.ToBGR();

                //prepare roi list
                List<RectangleRegion> rois = new List<RectangleRegion>();
                foreach(var map in crrInfo.ROIs) rois.Add(map.ROI);

                //detect
                var segss = crrInfo.Detector.Apply(img, rois.ToArray(), vimg);
                m_crrProfile.Clear();
                float x = 0;
                int roi_id = 0;
                List<float> segwidths = new List<float>();


                foreach(var segs in segss) {
                    var roi = crrInfo.ROIs[roi_id];
                    var p1 = roi.Segment.P1;
                    var p2 = roi.Segment.P2;
                    var vect = p2 - p1;
                    var sp1 = p1;
                    var sp2 = p1;

                    float psegpos = 0;

                    //segment ok thresholding
                    double seg_total_length = 0;
                    double seg_ok_length = 0;

                    for(int i = 0; i < segs.Length; i++) {
                        var seg = segs[i];
                        segwidths.Add(seg.Length);
                        //add a graph point
                        m_crrProfile.Add(x + seg.Position, seg.Length);

                        //draw ok segment
                        sp2 = seg.Position * vect + p1;
                        Color segcolor = Color.Lime;
                        var dlen = seg.Position - psegpos;

                        //draw ng segment
                        if(seg.Length < roi.ThresholdLower ||
                            seg.Length > roi.ThresholdUpper) {
                            segcolor = Color.Blue;
                        }
                        //accumulate ok length
                        else {
                            m_crrResult.AccumOKLength += dlen;
                            seg_ok_length += dlen;
                        }

                        m_crrResult.TotalLength += dlen;
                        seg_total_length += dlen;

                        m_crrModelImg.DrawLine(new Point((int)sp1.X, (int)sp1.Y),
                            new Point((int)sp2.X, (int)sp2.Y), segcolor, 2);
                        sp1 = sp2;
                        psegpos = seg.Position;
                    }
                    x += 1;
                    roi_id++;

                    m_crrResult.ReportOKNG(seg_ok_length * 100 / seg_total_length >= roi.OKThreshold);
                }
                graphProfile.AutoScaleAxes();

                //show pictures
                vimg.DrawRasterText(crrInfo.Camera.ToString(),
                    Mat.RasterFontID.Iosevka28,
                    new Point(5, imgs[0].Height - 30),
                    Color.Lime, Color.Black);
                imgCurrent.SetImage(vimg);
                imgVisualize.SetImage(m_crrModelImg);

                //STAT
                //add result images
                float avg_width = 0;
                float width_stdev = 0;
                if(segwidths.Count > 0) {
                    avg_width = segwidths.Average();
                    width_stdev = (float)System.Math.Sqrt(segwidths.Sum(v => System.Math.Pow(v - avg_width, 2)) / (segwidths.Count - 1));
                }
                m_crrResult.SegmentStats.Add(new DetectionResult.SegmentStat(avg_width, width_stdev));
                m_crrResult.ModelImage = m_crrModelImg;
                m_crrResult.InspectionCount++;
                lbl_InspectionCount.Text = $"{m_crrResult.InspectionCount}/{m_crrResult.TotalInspectionCount}";
                lbl_ContNGCount.Text = $"{m_crrResult.ContinuousNGCount}";
                m_crrResult.Images.Add(img);
                m_crrResult.Images.Add(vimg);
            }
        }

        void SaveTestImages() {
            if(m_isTestMode == false) return;
            //String dir = Registry.GetStringValue("TestImageDir", "");
            String dir = LotusAPI.Controls.FileDialog.ShowFolderBrowserDialog();

            if(dir == "") throw new Exception("Invalid image directory");

            //int dir_id = 0;
            //while (Directory.Exists(dir + $"/Test_{dir_id}")) dir_id++;
            //dir = dir + $"/Test_{dir_id}";
            //save timing file
            Json jt = new Json();
            jt = m_timingList.ToArray();
            jt.Save(dir + "/timing.json");

            var dir1 = dir + "/Camera1";
            var dir2 = dir + "/Camera2";
            if(Directory.Exists(dir1)) Directory.Delete(dir1, true);
            if(Directory.Exists(dir2)) Directory.Delete(dir2, true);
            Directory.CreateDirectory(dir1);
            Directory.CreateDirectory(dir2);
            //save files
            Logger.Debug("Saving image...");
            for(int i = 0; i < m_imgList1.Count; i++) {
                m_imgList1[i].Save(dir1 + "/" + m_filenames[i]);
                m_imgList2[i].Save(dir2 + "/" + m_filenames[i]);
            }
            Logger.Debug("OK");
        }

        void PrepareVision() {
            m_capthread.Pause();
            ClearImageList();
            ResetStat();
            m_maxTimingErrorMs = Registry.GetIntValue("MaxTimingErrorMs", 10);
            m_crrModelImg = (Mat)m_crrModelConfig.ModelImage.Clone();
            m_crrResult = new DetectionResult();
            m_crrResult.ModelName = m_crrModelConfig.ModelName;
            m_crrResult.OKThreshold = m_crrModelConfig.OKThreshold;
            m_crrResult.NumImage = m_crrModelConfig.Detectors.Count;
            m_crrResult.SkipCount = m_crrModelConfig.SkipCount;
            m_crrResult.MaxContinuousNGCount = m_crrModelConfig.ContinuousNGCount;
            m_isTestMode = Registry.GetBoolValue("TestMode", false);
            lbl_InspectionCount.Text = $"{m_crrResult.InspectionCount}/{m_crrResult.TotalInspectionCount}";
            currentResult.BackColor = Color.Yellow;
            currentResult.Text = "...";
            lbl_ContNGCount.Text = $"{m_crrResult.ContinuousNGCount}";
        }

        void SetCarType(int idx) {
            var models = Global.Instance.Models;
            //change visualize image
            m_crrModelConfig = models[idx];
            BeginInvoke(new Action(() => { modelName.ContentText = m_crrModelConfig.ModelName; }));
            imgVisualize.SetImage(models[idx].ModelImage);
        }

        void VisionInspectStart() {
            m_visionInspecting = true;
            m_inspectionStarted = false;
            m_capthread.Resume();
        }


        void VisionInspectFinished() {
            m_visionInspecting = false;
            if(m_isTestMode) return;
            //vision inspection finish
            //var okratio = m_accumOKLength / m_totalLength;
            //Logger.Info($"OK length={m_accumOKLength}");
            //Logger.Info($"Total length={m_totalLength}");
            //Logger.Info($"OK_RATIO ={okratio}");

            Action update_stat = new Action(() => {
                if(m_crrResult.IsOK) {
                    resultCounter.OKCount++;
                    currentResult.Text = "OK";
                    currentResult.ContentBackColor = Color.Lime;
                }
                else {
                    resultCounter.NGCount++;
                    currentResult.Text = "NG";
                    currentResult.ContentBackColor = Color.Red;
                }

                //allow 10 recent result
                List<Control> rrlist = new List<Control>();
                foreach(var c in layoutRecentResult.Controls) rrlist.Add((Control)c);
                rrlist.Add(new RecentResultItem(resultCounter.TotalCount, m_crrResult));

                rrlist.Sort((x, y) => ((RecentResultItem)y).ID.CompareTo(((RecentResultItem)x).ID));
                //keep last 10
                if(rrlist.Count > Registry.GetIntValue("RecentResultCount", 5)) rrlist.RemoveAt(rrlist.Count - 1);

                layoutRecentResult.SuspendLayout();
                layoutRecentResult.Controls.Clear();
                foreach(var c in rrlist) layoutRecentResult.Controls.Add(c);
                layoutRecentResult.ResumeLayout();

                SaveCurrentResult();
            });
            if(InvokeRequired) BeginInvoke(update_stat);
            else update_stat();
        }

        void SaveCurrentResult() {
            try {
                //capture screen shot
                var bmp = new Bitmap(Width, Height);
                this.DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
                m_crrResult.ScreenImage = bmp;
                m_crrResult.Save();
            } catch(Exception ex) {
                Logger.Error(ex.Message);
            }
        }


        #region DIO
        void OnDIOChanged(PinInfo pin, bool oldvalue, bool newvalue) {
            try {
                Logger.Debug(pin.ToString() + ": " + oldvalue + "->" + newvalue);
                //only care DI signal
                if(pin.Function != PinFunc.DI) return;

                switch(pin.Name) {
                    case "VisionPrepare":
                        if(newvalue == true) PrepareVision();
                        else SaveTestImages();
                        return;
                    case "CarType1": { if(newvalue == true) SetCarType(0); } return;
                    case "CarType2": { if(newvalue == true) SetCarType(1); } return;
                    case "CarType3": { if(newvalue == true) SetCarType(2); } return;
                    case "CarType4": { if(newvalue == true) SetCarType(3); } return;
                    case "VisionInspect":
                        if(newvalue == true) VisionInspectStart();
                        else VisionInspectFinished();
                        return;
                }
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        void OnControllerCommand(ControllerCommandItem cmd, string msg) {
            var action = new Action(() => {
                try {
                    //only care DI signal
                    Logger.Debug($"Received: {msg}");
                    if(cmd == null || cmd.Function != "DI") {
                        return;
                    }

                    switch(cmd.Name) {
                        //MD
                        case "CarType": {
                                int idx = int.Parse(msg.Substring(2));
                                SetCarType(idx - 1);
                                PrepareVision();
                            }
                            break;
                        //TR
                        case "SealerON":
                            if(m_waitForFirstTRSignal) {
                                VisionInspectStart();
                                m_waitForFirstTRSignal = false;
                            }
                            break;
                        //TF
                        case "SealerOFF": break;
                        //ST
                        case "VisionStart":
                            m_waitForFirstTRSignal = true;
                            break;
                        //ED
                        case "VisionEnd":
                            VisionInspectFinished();
                            SaveTestImages();
                            return;

                        //Keep alive
                        case "KJ":
                            if(btAutoManual.State == true)
                                Global.Instance.ControllerServer.Send($"RY1");
                            else
                                Global.Instance.ControllerServer.Send($"RY0");
                            break;
                    }

                    Logger.Debug($"Cmd: {cmd.Command}, {cmd.Text}");
                    Logger.Debug("Received: " + msg);
                } catch(Exception ex) {
                    Logger.Error(ex.Message);
                }
            });
            if(InvokeRequired) BeginInvoke(action);
            else action();
        }

        #endregion



        private void FormMain_FormClosing(object sender, FormClosingEventArgs e) {
            try {
                if(MessageBox.Show("Are you sure you want to close this app?",
                    "Close confirmation",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) {
                    var daq = Global.Instance.DAQ;
                    if(daq != null) daq.StopPolling();
                    Global.Instance.ControllerServer.Stop();
                    DisconnectAll();
                    return;
                }
            } catch(Exception ex) { Logger.Error(ex.Message); }
            e.Cancel = true;
        }
        void DisconnectAll() {
            try {
                if(m_capthread != null) m_capthread.Stop();
                Application.DoEvents();
                System.Threading.Thread.Sleep(500);

                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                if(cam1 != null) cam1.Disconnect();
                if(cam2 != null) cam2.Disconnect();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        private void btRetryConnect_Click(object sender, EventArgs e) {
            try {
                InitCameras();
                InitDetectorConfigs();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }

        private void toggleButton1_StateON(object sender) {
            Logger.Debug("Change mode: AUTO");
            btSetting.Enabled = false;
            daqView.EnableManualDI = false;
            daqView.EnableManualDO = false;
            var daq = Global.Instance.DAQ;
            if(Registry.GetStringValue("IOMethod", "None") == "DAQ") daq.StartPolling();
        }
        private void toggleButton1_StateOFF(object sender) {
            Logger.Debug("Change mode: MANUAL");
            daqView.EnableManualDI = true;
            daqView.EnableManualDO = true;
            btSetting.Enabled = true;
            var daq = Global.Instance.DAQ;
            daq.StopPolling();
        }

        private void btSetting_Load(object sender, EventArgs e) {

        }

        private void currentResult_Load(object sender, EventArgs e) {

        }

        void ControllerSend(string msg) {
            Global.Instance.ControllerServer.Send(msg);
        }


        private void btSetting_Click(object sender, EventArgs e) {
            try {
                PauseCaptureThread();
                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                m_formSetting.ShowDialog();
                if(cam1 != null && cam1.IsConnected) cam1.StartAcquisition();
                if(cam2 != null && cam2.IsConnected) cam2.StartAcquisition();
                ResumeCaptureThread();
            } catch(Exception ex) { Logger.Error(ex.Message); }
        }
    }
}

