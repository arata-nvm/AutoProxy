using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Win32;

namespace AutoProxy.Services
{
    static class AutorunService
    {

        public static bool Register()
        {
            var registry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (IsRegisted()) return false;
            registry?.SetValue("AutoProxy", System.Reflection.Assembly.GetExecutingAssembly().Location);
            return true;

        }

        public static bool Unregister()
        {
            var registry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            if (IsRegisted())
            {
                registry?.DeleteValue("AutoProxy", false);
                return true;
            }

            return false;
        }

        public static bool IsRegisted()
        {
            var registry = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run", true);

            return registry?.GetValue("AutoProxy") != null;
        }
    }
}
