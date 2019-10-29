using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoProxy.Models;

namespace AutoProxy.Integrations
{
    class IntegrationManager
    {

        private List<IIntegration> _integrations = new List<IIntegration>();

        public static IntegrationManager INSTANCE { get; } = new IntegrationManager();

        private IntegrationManager()
        {

        }

        public void Init()
        {
            AddIntegration(new GitIntegration());
            AddIntegration(new ScoopIntegration());
        }

        public void AddIntegration(IIntegration integration)
        {
            _integrations.Add(integration);
        }

        public void RemoveIntegration(IIntegration integration)
        {
            _integrations.Remove(integration);
        }

        public void SetProxy(ProxyInfo setting)
        {
            _integrations.ForEach(i => i.SetProxy(setting));
        }

        public void UnsetProxy()
        {
            _integrations.ForEach(i => i.UnsetProxy());
        }

    }
}
