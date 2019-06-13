using System;
using Microsoft.Win32;

namespace CS204 {
    
    /*
         0 	Timestamps and window scaling are disabled. 
         1 	Window scaling is enabled. (set to here)
         2 	Timestamps are enabled.
         3 	Timestamps and window scaling are enabled.  (default)
    */
    
    public class Tcp1323Opts {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters";
        
        public void Add() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("Tcp1323Opts", "1", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("Tcp1323Opts")!= null)
                {
                    key?.DeleteValue("Tcp1323Opts");
                    key?.Close();
                }
            }
        }
   
    }
}