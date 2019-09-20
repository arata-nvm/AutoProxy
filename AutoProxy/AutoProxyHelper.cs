using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProxy.Services;
using AutoProxy.Config;


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
                ProxySettingService.SetProxy(settings.First());
                NotificationService.SendNotify("プロキシを適用しました。", $"SSID: {ssid}");
            }
            else
            {
                ProxySettingService.UnsetProxy();
                NotificationService.SendNotify("プロキシを解除しました。");
            }
        }
    }
}
