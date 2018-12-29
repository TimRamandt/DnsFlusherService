using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace DnsFlusher {
    public partial class DnsService : ServiceBase {
        private Timer timer;
        public DnsService() {
            InitializeComponent();
            this.timer = new Timer();
        }

        protected override void OnStart(string[] args) {
            this.timer.Elapsed += new ElapsedEventHandler(this.elapsedEvent);
            this.timer.Interval = 10800000; //3 hours
            this.timer.Enabled = true;
            this.timer.Start();
        }

        private void elapsedEvent(object sender, ElapsedEventArgs e) {
            Process.Start("cmd","ipconfig /flushdns");
        }

        protected override void OnStop() {
        }
    }
}
