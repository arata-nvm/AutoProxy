using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AutoProxy.Settings
{
    [DataContract]
    public class GeneralSettings
    {
        [DataMember(Name = "language")]
        public string Language = "ja";
    }
}
