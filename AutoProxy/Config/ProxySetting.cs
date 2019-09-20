using System.Runtime.Serialization;

namespace AutoProxy.Config
{
    [DataContract]
    public class ProxySetting
    {
        [DataMember(Name = "ssid")]
        public string SSID { get; set; }

        [DataMember(Name = "proxyHost")]
        public string ProxyHost { get; set; }

        [DataMember(Name = "proxyPort")]
        public int ProxyPort { get; set; }

        [IgnoreDataMember]
        public string ProxyServer => $"{ProxyHost}:{ProxyPort}";

        public ProxySetting(string ssid, string proxyHost, int proxyPort)
        {
            this.SSID = ssid;
            this.ProxyHost = proxyHost;
            this.ProxyPort = proxyPort;
        }
    }
}
