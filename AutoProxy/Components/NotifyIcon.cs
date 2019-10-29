using System.ComponentModel;
using System.Windows;
using AutoProxy.Services;
using AutoProxy.Config;

namespace AutoProxy.Components
{
    public partial class NotifyIcon : Component
    {
        public NotifyIcon()
        {
            InitializeComponent();
            setAutorunMenuItem.Click += delegate {　AutoProxyHelper.RegisterAutorun(); };
            unsetAutorunMenuItem.Click += delegate { AutoProxyHelper.UnregisterAutorun(); };
            reloadConfigMenuItem.Click += delegate { 
                Configuration.Instance.LoadConfig(Configuration.GetDefaultConfigFilePath());
                AutoProxyHelper.CheckAndSetProxy();
            };
            exitMenuItem.Click += delegate { Application.Current.Shutdown(); };
        }

        public NotifyIcon(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
