using System.IO;
using System.Windows;
using System.Reflection;
using AutoProxy.Components;
using AutoProxy.Handlers;
using AutoProxy.Settings;
using AutoProxy.Services;
using AutoProxy.Integrations;

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
            AutoProxyConfig.Current.LoadConfig();
            IntegrationManager.INSTANCE.Init();
            AutoProxyHelper.CheckAndSetProxy();
        }

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            ProxySettingService.UnsetProxy();
            IntegrationManager.INSTANCE.UnsetProxy();
            this.notifyIcon.Dispose();
        }

    }
}
