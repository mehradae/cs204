using System;
using Microsoft.Win32;

namespace CS204 {

    public class TCP_no_delay {

        public void Add() {
            String path = "SOFTWARE\\Microsoft\\MSMQ";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    key.SetValue("TCPNoDelay", "1", RegistryValueKind.DWord);
                    key.Close();
                }
            }
        }

        public void Remove() {
            String path = "SOFTWARE\\Microsoft\\MSMQ";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    if (key.GetValue("TCPNoDelay") != null) {
                        key.DeleteValue("TCPNoDelay");
                        key.Close();
                    }
                }
            }
        }
    }
}
