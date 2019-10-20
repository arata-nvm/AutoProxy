using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AutoProxy.Config;
using AutoProxy.Services;

namespace AutoProxy.Integrations
{
    class ScoopIntegration : IIntegration
    {

        public void SetProxy(ProxySetting setting)
        {
            CommandService.RunCommand($"scoop config proxy {setting.ProxyServer}");
        }

        public void UnsetProxy()
        {
            CommandService.RunCommand($"scoop config rm proxy");
        }
    }
}
