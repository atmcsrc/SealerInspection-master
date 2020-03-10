using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LotusAPI;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
using LotusAPI.HW;
using LotusAPI.MV;

namespace ATMC.App.SealerInspection
{
    public sealed class Global
    {
        static Global instance = new Global();
        Timer tmr = new Timer();
        DateTime dt;
        public static Global Instance => instance;
        public delegate void OnResetTimerEventHandler();
        public event OnResetTimerEventHandler OnResetTimer;


        public ControllerServer ControllerServer { get; set; } = new ControllerServer();

        Global()
        {
            ResetTime = ResetTime;
            tmr.Interval = 60000;
            tmr.Tick += (o, e) =>
            {
                var ts = dt.Subtract(DateTime.Now);
                //Logger.Debug($"Counter reset in {ts.TotalMinutes} minutes");
                if (((int)ts.TotalMinutes == 0) && ts.TotalSeconds < 0)
                {
                    dt = dt.AddHours(24);
                    Logger.Info("Reset time: " + dt);
                    OnResetTimer?.Invoke();

                }
            };
            tmr.Start();
        }

        public string ResetTime
        {
            get { return Registry.GetStringValue("Setting", "ResetTime", "07:00"); }
            set
            {
                Registry.SetValue("Setting", "ResetTime", value);
                try
                {
                    DateTime.TryParseExact(ResetTime, "HH:mm", new CultureInfo("en-US"), DateTimeStyles.None, out dt);
                    var ts = dt.Subtract(DateTime.Now);
                    if (ts.TotalMinutes < 0) { dt = dt.AddHours(24); }
                    Logger.Info("Reset time: " + dt);
                }
                catch (Exception ex) { Logger.Error(ex.Message); }
            }
        }

        public string ServerIP
        {
            get { return Registry.GetStringValue("Setting", "ServerIP", "192.168.5.41"); }
            set
            {
                Registry.SetValue("Setting", "ServerIP", value);
                StartControllerServer();
            }
        }

        public static void StartControllerServer()
        {
            Instance.ControllerServer.IP = Instance.ServerIP;
            Instance.ControllerServer.Port = Registry.GetIntValue("Setting", "ServerPort", 5001);
            Instance.ControllerServer.Start();
        }


        //public AdvantechDaq DAQ = new AdvantechDaq();
        public CameraDevice Cam1  = null;
        public CameraDevice Cam2  = null;
        public List<ModelConfig> Models = new List<ModelConfig>();

        //public System.IO.DirectoryInfo ModelDirectory { get; set; } = new System.IO.DirectoryInfo("C:/");
    }
}
