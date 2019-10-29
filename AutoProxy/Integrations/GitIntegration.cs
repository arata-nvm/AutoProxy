using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using AutoProxy.Services;
using AutoProxy.Models;

namespace AutoProxy.Integrations
{
    class GitIntegration : IIntegration
    {
    
        public void SetProxy(ProxyInfo setting)
        {
            CommandService.RunCommand($"git config --global http.proxy {setting.ProxyServer}");
            CommandService.RunCommand($"git config --global https.proxy {setting.ProxyServer}");
        }

        public void UnsetProxy()
        {
            CommandService.RunCommand($"git config --global --unset http.proxy");
            CommandService.RunCommand($"git config --global --unset https.proxy");
        }
    }
}
