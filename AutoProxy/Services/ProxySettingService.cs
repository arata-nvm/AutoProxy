using Microsoft.Win32;
using AutoProxy.Models;

namespace AutoProxy.Services
{
    public static class ProxySettingService
    {

        private static string InternetSettingsKeyName = @"Software\Microsoft\Windows\CurrentVersion\Internet Settings";

        public static bool SetProxy(ProxyInfo setting)
        {
            var registry = Registry.CurrentUser.OpenSubKey(InternetSettingsKeyName, true);
            if (registry == null)
            {
                return false;   
            }
            registry.SetValue("ProxyEnable", 1);
            registry.SetValue("ProxyServer", setting.ProxyServer);
            return true;
        }

        public static bool UnsetProxy()
        {
            var registry = Registry.CurrentUser.OpenSubKey(InternetSettingsKeyName, true);
            if (registry == null)
            {
                return false;
            }
            registry.SetValue("ProxyEnable", 0);
            registry.SetValue("ProxyServer", "");
            return true;
        }
    }
}
