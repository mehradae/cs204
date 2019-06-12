using System;
using Microsoft.Win32;

namespace CS204 {

    public class IRP_Stack_Size {

        public void Add() {
            String path = @"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    key.SetValue("IRPStackSize", "32", RegistryValueKind.DWord); // change value from 15 to 32 (or up to 50)
                    key.Close();
                }
            }
        }

        public void Remove() {
            String path = @"SYSTEM\CurrentControlSet\Services\LanmanServer\Parameters";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key != null) {
                    if (key.GetValue("IRPStackSize") != null) {
                        key.SetValue("IRPStackSize", "15", RegistryValueKind.DWord);
                        key.Close();
                    }
                }
            }
        }
    }
}
