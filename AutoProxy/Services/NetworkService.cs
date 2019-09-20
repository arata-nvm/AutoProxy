using System;
using System.Linq;
using System.Diagnostics;

namespace AutoProxy.Services
{
    public static class NetworkService
    {
        public static string GetConnectingSSID()
        {
            var process = new Process
            {
                StartInfo =
                {
                    FileName = "netsh.exe",
                    Arguments = "wlan show interfaces",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };
            process.Start();

            var processOutput = process.StandardOutput.ReadToEnd();
            var ssidLine = processOutput.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault(l => l.Contains("SSID") && !l.Contains("BSSID"));
            if (ssidLine == null)
            {
                return string.Empty;
            }
            var ssid = ssidLine.Split(new[] { " : " }, StringSplitOptions.RemoveEmptyEntries)[1].TrimStart();
            return ssid;
        }
    }
}
