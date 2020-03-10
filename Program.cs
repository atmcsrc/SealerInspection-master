using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ATMC.Controls;
using LotusAPI;

namespace ATMC.App.SealerInspection {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Init registry
            Registry.SetApplicationName("ATMC\\SealerInspection");
            //lauch a slash screen with logo (null if nogo)
            FormSplash splash = new FormSplash(Properties.Resources.splash);
            FormMain form = new FormMain();
            splash.Terminate();
            Application.Run(form);
        }
    }
}
