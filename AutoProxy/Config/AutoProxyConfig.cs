using System.Collections.Generic;
using System.Runtime.Serialization;


namespace AutoProxy.Config
{
    [DataContract]
    public class AutoProxyConfig
    {
        [DataMember(Name = "proxies")]
        public List<ProxySetting> Proxies = new List<ProxySetting>();

    }
}
