using System;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace CS204
{
    public partial class MainScreen : Form
    {
        string setting = "";
        public MainScreen()
        {

            InitializeComponent();
            IpLable.Text = GetLocalIPAddress();
            PingHost("www.yahoo.co.jp");


            FileHandler(false);
        }

        private void FileHandler(bool status)
        {

            try
            {
                string path = "C:\\data.txt";

                if (status)
                {
                    StreamWriter st;
                    st = File.Exists(path) ? File.AppendText(path) : new StreamWriter(path);


                    st.WriteLine(DateTime.Now.AddHours(1) + " -- ping: " + OldPingTimelbl.Text
                        + " -- dropped packets: " + OldDropPcklbl.Text 
                        + " -- Jitter: " +OldJitter.Text +" -- Applied Setting: "+ setting);
                    st.Flush();
                    st.Close();
                }
                else
                {
                    if (File.Exists(path))
                    {
                        StreamReader sr = new StreamReader(path);
                        string line;
                        while ((line = sr.ReadLine()) != null)
                        {
                            PingHistory.Items.Add(line);
                        }
                        sr.Close();
                    }
                }
            }
            catch(IOException ex)
            {
                MessageBox.Show(ex.ToString(), "File Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnApply_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 10;
            foreach (object item in OptionList.Items){

                
                try
                {
                    EffectApply(item);
                    progressBar1.Value = 100;
                }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message);
                }

            }
            MessageBox.Show("All changes has been applied!", "All Done"
                       , MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void EffectApply(object item)
        {
                
                switch (item)
                {
                    case "TCP No Delay":
                        TCP_no_delay tCP_No_Delay = new TCP_no_delay();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        tCP_No_Delay.Add();
                        _ = setting == "" ? setting += "1" : setting += ",1";
                    }
                    else
                        tCP_No_Delay.Remove();
                        break;
                    case "TCP Window Size":
                        GlobalMaxTcpWindowSize globalMaxTcpWindow = new GlobalMaxTcpWindowSize();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        globalMaxTcpWindow.Add();
                        _ = setting == "" ? setting += "2" : setting += ",2";
                    }
                    else
                        globalMaxTcpWindow.Remove();
                        break;
                    case "IRP Stack Size":
                        IRP_Stack_Size iRP_Stack_Size = new IRP_Stack_Size();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        iRP_Stack_Size.Add();
                        _ = setting == "" ? setting += "3" : setting += ",3";
                    }
                    else
                        iRP_Stack_Size.Remove();
                        break;
                    case "Local Priority":
                        LocalPriority localPriority = new LocalPriority();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        localPriority.Add();
                        _ = setting == "" ? setting += "4" : setting += ",4";
                    }
                    else
                        localPriority.Remove();
                        break;
                    case "Max Connect Back Log":
                        MaxConnectBacklog maxConnectBacklog = new MaxConnectBacklog();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        maxConnectBacklog.Add();
                        _ = setting == "" ? setting += "5" : setting += ",5";
                    }
                    else
                        maxConnectBacklog.Remove();
                        break;
                    case "Max Free TCB":
                        MaxFreeTcbs maxFreeTcbs = new MaxFreeTcbs();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        maxFreeTcbs.Add();
                        _ = setting == "" ? setting += "6" : setting += ",6";
                    }
                    else
                        maxFreeTcbs.Remove();
                        break;
                    case "Max User Ports":
                        MaxUserPort maxUserPort = new MaxUserPort();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        maxUserPort.Add();
                        _ = setting == "" ? setting += "7" : setting += ",7";
                    }
                    else
                        maxUserPort.Remove();
                        break;
                    case "Network Throttling":
                        NetworkThrottlingIndex networkThrottlingIndex = new NetworkThrottlingIndex();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        networkThrottlingIndex.Add();
                        _ = setting == "" ? setting += "8" : setting += ",8";
                    }
                    else
                        networkThrottlingIndex.Remove();
                        break;
                    case "Non Best Effort Limit":
                        NonBestEffortLimit nonBestEffortLimit = new NonBestEffortLimit();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        nonBestEffortLimit.Add();
                        _ = setting == "" ? setting += "9" : setting += ",9";
                    }
                    else
                        nonBestEffortLimit.Remove();
                        break;
                    case "TCP OPT":
                        Tcp1323Opts tcp1323Opts = new Tcp1323Opts();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        tcp1323Opts.Add();
                        _ = setting == "" ? setting += "10" : setting += ",10";
                    }
                    else
                        tcp1323Opts.Remove();
                        break;
                    case "TCP Ack Frequency":
                        TCPackFrequency tCPackFrequency = new TCPackFrequency();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        tCPackFrequency.Add();
                        _ = setting == "" ? setting += "11" : setting += ",11";
                    }
                    else
                        tCPackFrequency.Remove();
                        break;
                    case "TCP Timed Wait Delay":
                        TcpTimedWaitDelay tcpTimedWaitDelay = new TcpTimedWaitDelay();
                    if (OptionList.CheckedItems.Contains(item))
                    {
                        tcpTimedWaitDelay.Add();
                        _ = setting == "" ? setting += "12" : setting += ",12";
                    }
                    else
                        tcpTimedWaitDelay.Remove();
                        break;
                    default:
                        MessageBox.Show("We dont have this option,How you find it ?!", "Error");
                        break;
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
                int jitter_counter = 0;
                long temp = 0;
                long jitter = 0;
                for (int i = 0; i < 10; i++)
                {
                    PingReply reply = pinger.Send(host, 120);
                    if (reply.Status == IPStatus.Success)
                    {
                        if (temp == 0)
                            temp = reply.RoundtripTime;
                        else
                        {
                            jitter+=Math.Abs(temp - reply.RoundtripTime);
                            if (jitter != 0)
                                jitter_counter++;
                        }

                        totalTime += reply.RoundtripTime;
                    }
                    else
                        counter++;
                }
           
                OldPingTimelbl.Text = ((totalTime / 10)).ToString() + " ms";
                OldDropPcklbl.Text = counter.ToString();
                if (jitter_counter != 0)
                    OldJitter.Text = (jitter / jitter_counter).ToString() + " ms";
                else
                    OldJitter.Text = "0";
                
                
            }
            catch (PingException er)
            {
                OldPingTimelbl.Text = "An Error Occurred!";
                MessageBox.Show(er.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

            FileHandler(true);
            
        }

    }
}
