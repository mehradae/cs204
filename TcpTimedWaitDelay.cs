using System;
using Microsoft.Win32;

namespace CS204 {
    
    public class TcpTimedWaitDelay {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        
        // range can be 30 - 300
        // recommended value 30
        // default value 120
        public void Add() {
            
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("TcpTimedWaitDelay", "30", RegistryValueKind.DWord);
                key?.SetValue("StrictTimeWaitSeqCheck", "1", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("TcpTimedWaitDelay") == null && 
                    key?.GetValue("StrictTimeWaitSeqCheck") == null) return;

                key.DeleteValue("TcpTimedWaitDelay");
                key.DeleteValue("StrictTimeWaitSeqCheck");
                key.Close();
            }
        }
    }
}