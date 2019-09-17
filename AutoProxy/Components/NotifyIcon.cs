using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoProxy.Components
{
    public partial class NotifyIcon : Component
    {
        public NotifyIcon()
        {
            InitializeComponent();
            menuItem_Exit.Click += delegate (object sender, EventArgs e)
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
