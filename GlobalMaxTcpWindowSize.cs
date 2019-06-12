using System;
using Microsoft.Win32;

namespace CS204 {
    public class GlobalMaxTcpWindowSize {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        
        
        // set at 65535 (65kb)
        // however this might be slow, can set at higher
        // like 131072 (128kb)
        // but it might be an old fix from years ago, so it might make internet slower.
        // if so, just completely remove
        
        public void Add() {
            
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("GlobalMaxTcpWindowSize", "65535", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("GlobalMaxTcpWindowSize") == null) return;

                key.DeleteValue("GlobalMaxTcpWindowSize");
                key.Close();
            }
        }    
    }
}