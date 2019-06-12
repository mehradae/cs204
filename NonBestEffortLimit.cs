using System;
using Microsoft.Win32;

namespace CS204 {
    
    // test this one not sure if it works to create both subkey and value like this
    public class NonBestEffortLimit {
        String path = "SOFTWARE\\Policies\\Microsoft\\Windows";
        
        public void Add() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                var subKey = key?.CreateSubKey("Psched");
                subKey?.SetValue("NonBestEffortLimit", "0", RegistryValueKind.DWord);
                subKey?.Close();
                key?.Close();
            }
        }

        public void Remove() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.DeleteSubKey("Psched");
                key?.Close();
            }
        }
    }
}