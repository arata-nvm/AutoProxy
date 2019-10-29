using System.Net.NetworkInformation;


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
            NetworkChange.NetworkAvailabilityChanged += OnNetworkAvailabilityChanged;
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
