using System.Linq;
using AutoProxy.Services;
using AutoProxy.Settings;
using AutoProxy.Integrations;
using AutoProxy.Properties;

namespace AutoProxy
{
    static class AutoProxyHelper
    {
        public static void CheckAndSetProxy()
        {
            var ssid = NetworkService.GetConnectingSSID();
            if (ssid == string.Empty) return;
            var settings = AutoProxyConfig.Current.Proxy.FindSetting(ssid);
            if (settings.Count != 0)
            {
                var setting = settings.First();
                ProxySettingService.SetProxy(setting);
                IntegrationManager.INSTANCE.SetProxy(setting);
                NotificationService.SendNotify(Resources.SetProxy, $"SSID: {ssid}");
            }
            else
            {
                ProxySettingService.UnsetProxy();
                IntegrationManager.INSTANCE.UnsetProxy();
                NotificationService.SendNotify(Resources.UnsetProxy);
            }
        }

        public static void RegisterAutorun()
        {
            AutorunService.Register();
            NotificationService.SendNotify(Resources.RegisteredAutorun);
        }

        public static void UnregisterAutorun()
        {
            AutorunService.Register();
            NotificationService.SendNotify(Resources.UnregisteredAutorun);
        }

    }
}
