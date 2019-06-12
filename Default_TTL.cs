using System;
using Microsoft.Win32;

namespace CS204 {

    public class Default_TTL {

        public void Add() {
            String path = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    key.SetValue("DefaultTTL", "64", RegistryValueKind.DWord); // default is 128, change to 64 (range 1-255, lower is better)
                    key.Close();
                }
            }
        }

        public void Remove() {
            String path = @"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    if (key.GetValue("DefaultTTL") != null) {
                        key.SetValue("DefaultTTL", "128", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
            }
        }
    }
}
