using System.ComponentModel;
using System.Windows;
using AutoProxy.Services;
using AutoProxy.Settings;
using AutoProxy.Properties;

namespace AutoProxy.Components
{
    public partial class NotifyIcon : Component
    {
        public NotifyIcon()
        {
            InitializeComponent();

            ApplyChangingLanguage();

            setAutorunMenuItem.Click += delegate {　AutoProxyHelper.RegisterAutorun(); };
            unsetAutorunMenuItem.Click += delegate { AutoProxyHelper.UnregisterAutorun(); };
            reloadConfigMenuItem.Click += delegate { 
                AutoProxyConfig.Current.LoadConfig();
                AutoProxyHelper.CheckAndSetProxy();
                ApplyChangingLanguage();
            };
            exitMenuItem.Click += delegate { Application.Current.Shutdown(); };
        }

        public NotifyIcon(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void ApplyChangingLanguage()
        {
            setAutorunMenuItem.Text = Resources.SetAutorunMenuItem;
            unsetAutorunMenuItem.Text = Resources.UnsetAutorunMenuItem;
            reloadConfigMenuItem.Text = Resources.ReloadConfigMenuItem;
            exitMenuItem.Text = Resources.ExitMenuItem;
        }
    }
}
