using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
