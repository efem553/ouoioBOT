using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ouoioBOT
{
    public class ShellLayer
    {
        
        public Process proc = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = Application.StartupPath+"\\platform-tools\\adb.exe",
                Arguments = "devices",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };

        public Process takeIpAdress = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = Application.StartupPath + "\\platform-tools\\adb.exe",
                Arguments = "shell ifconfig ccmni0",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };

        public Process offMobileData = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = Application.StartupPath + "\\platform-tools\\adb.exe",
                Arguments = "shell svc data disable",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };

        public Process onMobileData = new Process
        {
            StartInfo = new ProcessStartInfo
            {
                FileName = Application.StartupPath + "\\platform-tools\\adb.exe",
                Arguments = "shell svc data enable",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            }
        };
    }
}
