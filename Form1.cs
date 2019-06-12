using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CS204
{
    public partial class MainScreen : Form
    {
        bool changed = false;
        public MainScreen()
        {
            InitializeComponent();
            IpLable.Text = GetLocalIPAddress();
            PingHost("4.2.2.4");
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {

            foreach (object item in OptionList.Items){

                EffectApply(item);

                
            }

            //try
            //{
            //    progressBar1.Value = 10;
            //    new TCP_no_delay().Remove();
            //    progressBar1.Value = 20;
            //    ReducePing();
            //}
            //catch (Exception er)
            //{
            //    MessageBox.Show(er.Message);
            //}
        }

        private void EffectApply(object item)
        {
            if (OptionList.CheckedItems.Contains(item))
            {
                MessageBox.Show(item.ToString());
                switch (item)
                {
                    case "TCP No Delay":
                        TCP_no_delay tCP_No_Delay = new TCP_no_delay();
                        if (OptionList.CheckedItems.Contains(item))
                            tCP_No_Delay.Add();
                        else
                            tCP_No_Delay.Remove();
                        break;
                    case "TCP Window Size":
                        GlobalMaxTcpWindowSize globalMaxTcpWindow = new GlobalMaxTcpWindowSize();
                        if (OptionList.CheckedItems.Contains(item))
                            globalMaxTcpWindow.Add();
                        else
                            globalMaxTcpWindow.Remove();
                        break;
                    case "IRP Stack Size":
                        IRP_Stack_Size iRP_Stack_Size = new IRP_Stack_Size();
                        if (OptionList.CheckedItems.Contains(item))
                            iRP_Stack_Size.Add();
                        else
                            iRP_Stack_Size.Remove();
                        break;
                    case "Local Priority":
                        LocalPriority localPriority = new LocalPriority();
                        if (OptionList.CheckedItems.Contains(item))
                            localPriority.Add();
                        else
                            localPriority.Remove();
                        break;
                    case "Max Connect Back Log":
                        MaxConnectBacklog maxConnectBacklog = new MaxConnectBacklog();
                        if (OptionList.CheckedItems.Contains(item))
                            maxConnectBacklog.Add();
                        else
                            maxConnectBacklog.Remove();
                        break;
                    case "Max Free TCB":
                        MaxFreeTcbs maxFreeTcbs = new MaxFreeTcbs();
                        if (OptionList.CheckedItems.Contains(item))
                            maxFreeTcbs.Add();
                        else
                            maxFreeTcbs.Remove();
                        break;
                    case "Max User Ports":
                        MaxUserPort maxUserPort = new MaxUserPort();
                        if (OptionList.CheckedItems.Contains(item))
                            maxUserPort.Add();
                        else
                            maxUserPort.Remove();
                        break;
                    case "Network Throttling":
                        NetworkThrottlingIndex networkThrottlingIndex = new NetworkThrottlingIndex();
                        if (OptionList.CheckedItems.Contains(item))
                            networkThrottlingIndex.Add();
                        else
                            networkThrottlingIndex.Remove();
                        break;
                    case "Non Best Effort Limit":
                        NonBestEffortLimit nonBestEffortLimit = new NonBestEffortLimit();
                        if (OptionList.CheckedItems.Contains(item))
                            nonBestEffortLimit.Add();
                        else
                            nonBestEffortLimit.Remove();
                        break;
                    case "TCP OPT":
                        Tcp1323Opts tcp1323Opts = new Tcp1323Opts();
                        if (OptionList.CheckedItems.Contains(item))
                            tcp1323Opts.Add();
                        else
                            tcp1323Opts.Remove();
                        break;
                    case "TCP Ack Frequency":
                        TCPackFrequency tCPackFrequency = new TCPackFrequency();
                        if (OptionList.CheckedItems.Contains(item))
                            tCPackFrequency.Add();
                        else
                            tCPackFrequency.Remove();
                        break;
                    case "TCP Timed Wait Delay":
                        TcpTimedWaitDelay tcpTimedWaitDelay = new TcpTimedWaitDelay();
                        if (OptionList.CheckedItems.Contains(item))
                            tcpTimedWaitDelay.Add();
                        else
                            tcpTimedWaitDelay.Remove();
                        break;
                    default:
                        MessageBox.Show("We dont have this option,How you find it ?!", "Error");
                        break;
                }
            }
            else
            {
                MessageBox.Show(item.ToString() + " Not Selected");
            }

        }

        private void RdMan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdMan.Checked)
            {
                btnApply.Enabled = true;
                OptionList.Enabled = true;
            }
            else
            {
                btnApply.Enabled = true;
                OptionList.Enabled = false;
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
                if (changed)
                {
                    NewPingtimelbl.Text = (totalTime / 10).ToString() + " ms";
                    NewDropPcklbl.Text = counter.ToString();
                }
                else
                {
                    OldPingTimelbl.Text = (totalTime / 10).ToString() + " ms";
                    OldDropPcklbl.Text = counter.ToString();
                }
                
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

//        private void ReducePing()
//        {
//            //const string userRoot = "HKEY_LOCAL_MACHINE";
//            //const string subkey = "RegistrySetValueExample";
//            //const string keyName = userRoot + "\\" + subkey;
//            //string[] path = Registry.LocalMachine.;
//            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
//            using (RegistryKey mykey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true))
//            {
//                if (mykey != null)
//                {
//                    MessageBox.Show("Its working");
//                    mykey.SetValue("NetworkThrottlingIndex", Int32.MaxValue, RegistryValueKind.DWord);
//                    mykey.Close();
//                }
//            }
//
//               
//
//        }

        private void OptionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CheckedListBox chb = (CheckedListBox)sender;
            //bool Active =((CheckBox) chb.gets).Checked;

            //if(Active)
            //MessageBox.Show((string)chb.SelectedItem);
            //if (chb.SelectedItem.ToString().Equals("TCP No Delay")) {


            //}
        }
    }
}
