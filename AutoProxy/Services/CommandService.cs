using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AutoProxy.Services
{
    static class CommandService
    {
        public static void RunCommand(string cmd)
        {
            var p = new Process()
            {
                StartInfo = 
                {
                    FileName = "cmd.exe",
                    Arguments = $"/c {cmd}",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                }
            };

            p.Start();
            p.WaitForExit();
            p.Close();
        }
    }
}
