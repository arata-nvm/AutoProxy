using System.Linq;
using AutoProxy.Services;
using AutoProxy.Config;
using AutoProxy.Integrations;

namespace AutoProxy
{
    static class AutoProxyHelper
    {
        public static void CheckAndSetProxy()
        {
            var ssid = NetworkService.GetConnectingSSID();
            if (ssid == string.Empty) return;
            var settings = Configuration.Instance.FindSetting(ssid);
            if (settings.Count != 0)
            {
                var setting = settings.First();
                ProxySettingService.SetProxy(setting);
                IntegrationManager.INSTANCE.SetProxy(setting);
                NotificationService.SendNotify("プロキシを適用しました。", $"SSID: {ssid}");
            }
            else
            {
                ProxySettingService.UnsetProxy();
                IntegrationManager.INSTANCE.UnsetProxy();
                NotificationService.SendNotify("プロキシを解除しました。");
            }
        }

        public static void RegisterAutorun()
        {
            AutorunService.Register();
            NotificationService.SendNotify("自動実行を設定しました。");
        }

        public static void UnregisterAutorun()
        {
            AutorunService.Register();
            NotificationService.SendNotify("自動実行を解除しました。");
        }

    }
}
