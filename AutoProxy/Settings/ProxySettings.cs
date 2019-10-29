using AutoProxy.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AutoProxy.Settings
{
    [DataContract]
    public class ProxySettings
    {
        [DataMember(Name = "proxies")]
        public List<ProxyInfo> Proxies = new List<ProxyInfo>();

        public void AddSetting(ProxyInfo setting)
        {
            Proxies.Add(setting);
        }

        public List<ProxyInfo> FindSetting(string ssidToFind)
        {
            return Proxies.FindAll(s => s.SSID == ssidToFind);
        }
    }
}
