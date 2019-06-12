using System;
using Microsoft.Win32;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;


namespace CS204
{
    public class Try_Key_Changes
    {
        //private void BtnApply_Click(object sender, EventArgs e) {
        //    RegistryKey key = Registry.CurrentUser
        //        .OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);

        //}
    
        private void Tcp_ack() {
            // HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\MSMQ
            String path = "SOFTWARE\\Microsoft\\MSMQ";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {                
                    key.SetValue("TCPNoDelay", "1", RegistryValueKind.DWord);
                    key.Flush();
                    key.Close();
                }
            }                
        }
    }
}
