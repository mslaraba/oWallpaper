using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.ServiceProcess;
using System.Text;

namespace oWallpaper
{
    public partial class WallpaperService : ServiceBase
    {
        private System.Diagnostics.EventLog eventLog1;
        public WallpaperService()
        {
            InitializeComponent();

            System.Timers.Timer tt = new System.Timers.Timer(5000);
            tt.Elapsed += Tt_Elapsed;
            tt.Start();
        }

        private void Tt_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            File.AppendAllText(@"d:\svc.txt", Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }

        protected override void OnStart(string[] args)
        {
            File.AppendAllText(@"d:\svc.txt", Environment.NewLine + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
        }
   
        protected override void OnStop()
        {
        }
    }
}
