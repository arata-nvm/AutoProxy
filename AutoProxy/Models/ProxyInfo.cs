using System.Runtime.Serialization;

namespace AutoProxy.Models
{
    [DataContract]
    public class ProxyInfo
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
