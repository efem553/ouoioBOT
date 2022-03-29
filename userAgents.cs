using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ouoioBOT
{
    public static class userAgents
    {

        public static string takeRandomUserAgent()
        {
            string[] allLines = File.ReadAllLines(Application.StartupPath + "\\user-agents.txt");
            Random rnd1 = new Random();
            return allLines[rnd1.Next(allLines.Length)];
        }

    }
}
