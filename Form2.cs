using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ouoioBOT
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string targetUrl = "";
        public string userAgent = userAgents.takeRandomUserAgent();
        
        ShellLayer sl = new ShellLayer();
        private void Form2_Load(object sender, EventArgs e)
        {
            targetUrl = Form1.targetUrl;
            writeIpAdress();

            logTextBox.AppendText("Hedef Adres: " +targetUrl+ Environment.NewLine);
            logTextBox.AppendText("User Agent: " + userAgent + Environment.NewLine);
            webBrowser1.Navigate(targetUrl, null, null,
                    "User-Agent: "+userAgent);

        }

        public void startAction()
        {
            sl.offMobileData.Start();
            sl.offMobileData.Close();
            System.Threading.Thread.Sleep(4000);
            sl.onMobileData.Start();
            sl.onMobileData.Close();
            System.Threading.Thread.Sleep(4000);
            writeIpAdress();
            userAgent = userAgents.takeRandomUserAgent();
            logTextBox.AppendText("Hedef Adres: " + targetUrl + Environment.NewLine);
            logTextBox.AppendText("User Agent: " + userAgent + Environment.NewLine);
            navigateURL();


        }
        public void navigateURL()
        {

            webBrowser1.Navigate(targetUrl, null, null,
        "User-Agent: " + userAgent);
        }
        
        public void writeIpAdress()
        {
            
            sl.takeIpAdress.Start();
            while (!sl.takeIpAdress.StandardOutput.EndOfStream)
            {
                string line = sl.takeIpAdress.StandardOutput.ReadLine();
                if (line.StartsWith("          inet addr:"))
                {
                    logTextBox.AppendText("İp Adresi: " + line.Split(':')[1].Split(' ')[0] + Environment.NewLine);
                }
            }
            sl.takeIpAdress.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                return;
            else
            {
                HtmlElement link = webBrowser1.Document.GetElementById("btn-main");
                if (link != null)
                {
                    System.Threading.Thread.Sleep(5000);
                    link.InvokeMember("Click");
                }
                else
                {
                    if (webBrowser1.Url.ToString().StartsWith("https://ouo.io/"))
                        return;
                    else if (webBrowser1.Url.ToString().StartsWith("about:blank"))
                    {

                        startAction();
                    }
                    else
                    {
                        System.Threading.Thread.Sleep(1000);
                        webBrowser1.Navigate("about:blank");
                    }
                }
            }
        }

        private void webBrowser1_NewWindow(object sender, CancelEventArgs e)
        {
        
            e.Cancel = true;
        }
    }
}
