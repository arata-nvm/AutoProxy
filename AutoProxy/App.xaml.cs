using System.Windows;
using AutoProxy.Components;
using AutoProxy.Handlers;
using AutoProxy.Config;
using AutoProxy.Services;

namespace AutoProxy
{
    /// <summary>
    /// App.xaml の相互作用ロジック
    /// </summary>
    public partial class App : Application
    {
        private readonly NotifyIcon notifyIcon = new NotifyIcon();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            this.ShutdownMode = ShutdownMode.OnExplicitShutdown;
            NetworkHandler.Instance.Init();
            Configuration.Instance.LoadConfig("config.json");
            AutoProxyHelper.CheckAndSetProxy();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            ProxySettingService.UnsetProxy();
            this.notifyIcon.Dispose();
        }

    }
}
