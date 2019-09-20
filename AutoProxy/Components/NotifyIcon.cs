using System.ComponentModel;
using System.Windows;

namespace AutoProxy.Components
{
    public partial class NotifyIcon : Component
    {
        public NotifyIcon()
        {
            InitializeComponent();
            menuItem_Exit.Click += delegate
            {
                Application.Current.Shutdown();
            };
        }

        public NotifyIcon(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
