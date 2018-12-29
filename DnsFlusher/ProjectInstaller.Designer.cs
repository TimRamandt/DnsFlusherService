using System.ServiceProcess;

namespace DnsFlusher {
    partial class ProjectInstaller {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private System.ServiceProcess.ServiceProcessInstaller serviceProcessInstaller;
        private System.ServiceProcess.ServiceInstaller dnsFlushInstaller;

        private void InitializeComponent() {
            this.serviceProcessInstaller = new System.ServiceProcess.ServiceProcessInstaller();
            this.dnsFlushInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // serviceProcessInstaller1
            // 
            this.serviceProcessInstaller.Password = null;
            this.serviceProcessInstaller.Username = null;
            // 
            // serviceInstaller1
            // 
            this.dnsFlushInstaller.ServiceName = "DnsFlusher";
            // 
            // ProjectInstaller
            // 
            this.dnsFlushInstaller.StartType = ServiceStartMode.Automatic;
            this.dnsFlushInstaller.Description = "Flushes the dns every 3 hours";
            this.serviceProcessInstaller.Account = ServiceAccount.LocalSystem;

            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
                this.serviceProcessInstaller,
                this.dnsFlushInstaller}
            );
        }
    }
}