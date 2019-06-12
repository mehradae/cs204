using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS204
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            IpLable.Text = GetLocalIPAddress();
            PingHost("4.2.2.4");
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            //RegistryKey key = Registry.CurrentUser
            //    .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);


            try
            {
                ReducePing();
                //MessageBox.Show("SUccess");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void RdMan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMan.Checked)
            {
                btnApply.Enabled = true;
            }
            else
            {
                btnApply.Enabled = true;
            }
        }

        public void PingHost(string host)
        {

            Ping pinger = null;

            try
            {
                pinger = new Ping();
                long totalTime = 0;
                int counter = 0;
                for (int i = 0; i < 10; i++)
                {
                    PingReply reply = pinger.Send(host, 120);
                    if (reply.Status == IPStatus.Success)
                    {
                        totalTime += reply.RoundtripTime;
                    }
                    else
                        counter++;
                }
                OldPingTimelbl.Text = (totalTime / 10).ToString() + " ms";
                OldDropPcklbl.Text = counter.ToString();
            }
            catch (PingException er)
            {
                OldPingTimelbl.Text = "An Error Occurred!";
                MessageBox.Show("Error", er.Message);
            }
            finally
            {
                if (pinger != null)
                {
                    pinger.Dispose();
                }
            }
        }

        public static string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }

        private void ReducePing()
        {
            //const string userRoot = "HKEY_LOCAL_MACHINE";
            //const string subkey = "RegistrySetValueExample";
            //const string keyName = userRoot + "\\" + subkey;
            //string[] path = Registry.LocalMachine.;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (RegistryKey mykey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true))
            {
                if (mykey != null)
                {
                    MessageBox.Show("Its working");
                    mykey.SetValue("NetworkThrottlingIndex", Int32.MaxValue, RegistryValueKind.DWord);
                    mykey.Flush();
                    mykey.Close();
                }
            }

               

        }
    }
}
