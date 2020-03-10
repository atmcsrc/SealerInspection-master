using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LotusAPI.Controls;
using LotusAPI.HW;
using LotusAPI.MV;
using LotusAPI;
using System.Threading;

namespace ATMC.App.SealerInspection
{
    public partial class FormCameraTool : Form
    {
        System.Windows.Forms.Timer tmr = new System.Windows.Forms.Timer();
        public FormCameraTool()
        {
            InitializeComponent();
            var cam1 = Global.Instance.Cam1;
            var cam2 = Global.Instance.Cam2;
            Logger.Warn($"Disconnecting all cameras...");
            if (cam1 != null) cam1.Disconnect();
            if (cam2 != null) cam2.Disconnect();

            tmr.Interval = 100;
            tmr.Tick += (o_, e_) =>
            {
                tmr.Enabled = false;
                OnTimer();
                tmr.Enabled = true;
            };
        }
        void OnTimer()
        {

            try
            {
                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                if (cam1 != null)
                {
                    cam1.Trigger();
                    var img1 = cam1.Capture();
                    imageView1.SetImage(img1);
                }
                if (cam2 != null)
                {
                    cam2.Trigger();
                    var img2 = cam2.Capture();
                    imageView2.SetImage(img2);
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btCam1_Click(object sender, EventArgs e)
        {
            ConnectCamera(ref Global.Instance.Cam1);
        }
        private void btCam2_Click(object sender, EventArgs e)
        {
            ConnectCamera(ref Global.Instance.Cam2);
        }

        void SetImg1(Mat img1)
        {
            BeginInvoke(new Action(() => { imageView1.SetImage(img1); GC.Collect(); }));
        }
        void SetImg2(Mat img2)
        {
            BeginInvoke(new Action(() => { imageView2.SetImage(img2); GC.Collect(); }));
        }


        void ConnectCamera(ref CameraDevice cam)
        {
            try
            {
                btStop_Click(null, null);
                FormCameraConnect fc = new FormCameraConnect();
                if (fc.ShowDialog() == DialogResult.OK)
                {
                    cam = fc.Camera;
                    return;
                }
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
            cam = null;
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            try
            {

                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                if (cam1 != null && cam1.IsConnected) cam1.StartAcquisition();
                if (cam2 != null && cam2.IsConnected) cam2.StartAcquisition();
                tmr.Enabled = true;
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btStop_Click(object sender, EventArgs e)
        {
            try
            {
                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                if (cam1 != null) cam1.StopAcquisition();
                if (cam2 != null) cam2.StopAcquisition();
                tmr.Enabled = false;
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btSaveConnectionSetting_Click(object sender, EventArgs e)
        {
            try
            {
                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                string filename = LotusAPI.Controls.FileDialog.ShowSaveJsonFileDialog();
                if (filename == null) return;
                Json j = new Json();
                cam1.DeviceInfo.Write(j["Camera1"]["Info"]);
                cam1.Write(j["Camera1"]["Config"]);
                cam2.DeviceInfo.Write(j["Camera2"]["Info"]);
                cam1.Write(j["Camera2"]["Config"]);
                j.Save(filename);
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void FormCameraTool_Load(object sender, EventArgs e)
        {

        }

        private void btConnectFromInfo_Click(object sender, EventArgs e)
        {
            try
            {
                var cam1 = Global.Instance.Cam1;
                var cam2 = Global.Instance.Cam2;
                btStop_Click(null, null);
                string filename = LotusAPI.Controls.FileDialog.ShowOpenJsonFileDialog();
                if (filename == null) return;
                CameraUtils.ConnectCameraFromFile(
                    ref Global.Instance.Cam1,
                    ref Global.Instance.Cam2, filename);
                if (cam1.IsConnected && cam2.IsConnected)
                    btStart_Click(null, null);
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void FormCameraTool_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                btStop_Click(null, null);
                //if (cam1 != null) cam1.Disconnect();
                //if (cam2 != null) cam2.Disconnect();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btCamSetting1_Click(object sender, EventArgs e)
        {
            try
            {
                var cam1 = Global.Instance.Cam1;
                (new LotusAPI.Controls.FormSettingEditor("Camera1 setting", "\\Camera1\\Config", cam1)).ShowDialog();
                cam1.Invalidate();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }

        private void btCamSetting2_Click(object sender, EventArgs e)
        {
            try
            {
                var cam2 = Global.Instance.Cam2;
                (new LotusAPI.Controls.FormSettingEditor("Camera2 setting", "\\Camera2\\Config", cam2)).ShowDialog();
                cam2.Invalidate();
            }
            catch (Exception ex) { Logger.Error(ex.Message); }
        }
    }
}
