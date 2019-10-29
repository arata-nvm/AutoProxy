using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using AutoProxy.Properties;
using AutoProxy.Settings;

namespace AutoProxy.Services
{
    class ResourceService
    {
        public static ResourceService Current { get; } = new ResourceService();

        public Resources Resources { get; } = new Resources();

        public void ChangeCulture(string name)
        {
            Resources.Culture = CultureInfo.GetCultureInfo(name);
            AutoProxyConfig.Current.General.Language = Resources.Culture.Name;
        }
    }
}
