using System;
using Microsoft.Win32;

namespace CS204 {

    public class LocalPriority {
        String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\ServiceProvider";

        public void Add() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("LocalPriority", "4", RegistryValueKind.DWord);
                key?.SetValue("HostsPriority", "5", RegistryValueKind.DWord);
                key?.SetValue("DnsPriority", "6", RegistryValueKind.DWord);
                key?.SetValue("NetbtPriority", "7", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {
            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("LocalPriority", "499", RegistryValueKind.DWord);
                key?.SetValue("HostsPriority", "500", RegistryValueKind.DWord);
                key?.SetValue("DnsPriority", "2000", RegistryValueKind.DWord);
                key?.SetValue("NetbtPriority", "2001", RegistryValueKind.DWord);
                key?.Close();
            }
        }
    }
}