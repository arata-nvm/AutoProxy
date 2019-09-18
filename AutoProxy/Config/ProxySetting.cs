using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProxy.Config
{
    public class ProxySetting
    {
        public string SSID;
        public string ProxyHost;
        public int ProxyPort;
        public string ProxyServer
        {
            get { return $"{ProxyHost}:{ProxyPort}"; }
        }

        public ProxySetting()
        {

        }

        public ProxySetting(string ssid, string proxyHost, int proxyPort)
        {
            this.SSID = ssid;
            this.ProxyHost = proxyHost;
            this.ProxyPort = proxyPort;
        }
    }
}
