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
        public string ProxyPort { get; set; }

        [IgnoreDataMember]
        public string ProxyServer => $"{ProxyHost}:{ProxyPort}";
    }
}
