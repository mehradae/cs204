using System;
using Microsoft.Win32;

namespace CS204 {

    public class MaxFreeTcbs {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        
        public void Add() {
            
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                //range between 16,000 - 65,536
                key?.SetValue("MaxFreeTcbs", "65536", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("MaxFreeTcbs") == null) return;

                key.DeleteValue("MaxFreeTcbs");
                key.Close();
            }
        }    
    }
}