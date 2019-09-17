using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using AutoProxy.Components;

namespace AutoProxy
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private NotifyIcon notifyIcon = new NotifyIcon();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            this.notifyIcon.Dispose();
        }

    }
}
