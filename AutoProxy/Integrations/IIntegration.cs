using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProxy.Models;

namespace AutoProxy.Integrations
{
    interface IIntegration
    {

        void SetProxy(ProxyInfo setting);

        void UnsetProxy();

    }
}
