using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ouoioBOT
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();

        }
        public static string targetUrl = "";
        Form2 frm2 = new Form2();
        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TakeDeviceInfo();
        }

        


        private void Form1_Load(object sender, EventArgs e)
        {
            InitTimer();
            metroTextBox1.Focus();
        }

        public void TakeDeviceInfo()
        {
            Boolean beforeDevicePrint = false;
            ShellLayer sl = new ShellLayer();
            sl.proc.Start();
            while (!sl.proc.StandardOutput.EndOfStream)
            {
                string line = sl.proc.StandardOutput.ReadLine();
                // do something with line

                if (beforeDevicePrint == true)
                {

                    if (line.EndsWith("unauthorized"))
                    {
                        deviceStatus.ForeColor = Color.Red;
                        deviceStatus.Text = "Lütfen ADB İçin İzin Verin";
                        beforeDevicePrint = false;

                    }
                    else if (line.EndsWith("device"))
                    {
                        deviceStatus.ForeColor = Color.Green;
                        deviceStatus.Text = "Bağlı";
                        beforeDevicePrint = false;
                    }
                    else
                    {
                        deviceStatus.ForeColor = Color.Red;
                        deviceStatus.Text = "Bağlı Değil";
                        beforeDevicePrint = false;
                        try
                        {
                            frm2.Close();
                        }
                        catch (ObjectDisposedException ex)
                        {
                            // Form has been closed
                        }
                    }
                }

                if (line.StartsWith("List of devices attached"))
                {
                    beforeDevicePrint = true;

                }

            }
            sl.proc.Close();
        }

        private void consoleOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBox1.Text))
            {
                MetroMessageBox.Show(Owner,"Lütfen Geçerli Bir Adres Girin!");
            }
            else
            {
                targetUrl = metroTextBox1.Text;
                
                frm2.Show();
            }
        }
    }
}
