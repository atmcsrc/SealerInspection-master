using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusAPI;
using LotusAPI.HW;

namespace ATMC.App.SealerInspection
{
    public class CameraUtils
    {
        delegate void fn_connect(ref CameraDevice cam, string node);
        public static void ConnectCameraFromFile(ref CameraDevice cam1, ref CameraDevice cam2, string filename)
        {
            if (filename == "") throw new Exception("Invalid camera info file, input file: " + filename);
            Logger.Debug("Loading camera setting...");
            Json j = Json.ReadFromFile(filename);
            if (cam1 == null) cam1 = new CameraDevice(CameraType.BaslerGigECam);
            if (cam2 == null) cam2 = new CameraDevice(CameraType.BaslerGigECam);
            //refresh camera list
            cam1.GetDevices();

            fn_connect fn_connect = (ref CameraDevice cam, string node) =>
            {
                if (cam.IsConnected) return;

                DeviceInfo dev = new GigeCameraDeviceInfo();
                Logger.Debug("Conneting " + node + "...");
                dev.Read(j[node]["Info"]);
                for (int i = 0; i < 1; i++)
                {
                    if (cam.Connect(dev)) break;
                    System.Threading.Thread.Sleep(1000);
                }
                cam.Read(j[node]["Config"]);
                cam.Invalidate();
                if (cam.IsConnected) Logger.Debug($"Connected to camera {dev.Signature}");
                else Logger.Error("Failed");
            };

            fn_connect(ref cam1, "Camera1");
            fn_connect(ref cam2, "Camera2");
        }
    }
}
