using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProxy.Config;

namespace AutoProxy.Integrations
{
    interface IIntegration
    {

        void SetProxy(ProxySetting setting);

        void UnsetProxy();

    }
}
