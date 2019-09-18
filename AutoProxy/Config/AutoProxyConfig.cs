using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AutoProxy.Config
{
    public class AutoProxyConfig
    {
        private List<ProxySetting> settings = new List<ProxySetting>();

        public static AutoProxyConfig Instance { get; } = new AutoProxyConfig();

        private AutoProxyConfig()
        {

        }

        public void AddSetting(ProxySetting setting)
        {
            settings.Add(setting);
        }

        public List<ProxySetting> FindSetting(string SSIDToFind)
        {
            return settings.FindAll(delegate (ProxySetting s)
            {
                return s.SSID == SSIDToFind;
            });
        }
    }
}
