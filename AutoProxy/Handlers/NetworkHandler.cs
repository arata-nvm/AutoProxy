using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using AutoProxy.Services;
using AutoProxy.Config;


namespace AutoProxy.Handlers
{
    public class NetworkHandler
    {

        public static NetworkHandler Instance { get; } = new NetworkHandler();

        private NetworkHandler()
        {

        }

        public void Init()
        {
            NetworkChange.NetworkAvailabilityChanged +=
                new NetworkAvailabilityChangedEventHandler(
                    OnNetworkAvailabilityChanged);
        }

        private void OnNetworkAvailabilityChanged(object sender, NetworkAvailabilityEventArgs args)
        {
            if (args.IsAvailable)
            {
                AutoProxyHelper.CheckAndSetProxy();
            }
        }

    }
}
