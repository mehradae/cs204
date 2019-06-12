using System;
using Microsoft.Win32;

namespace CS204 {
    public class MaxUserPort {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        
        // range between 5000 - 65534
        // default 5000
        public void Add() {
            
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("MaxUserPort", "65534", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("MaxUserPort") == null) return;

                key.DeleteValue("MaxUserPort");
                key.Close();
            }
        }    
    }
}