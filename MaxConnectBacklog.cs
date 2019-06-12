using System;
using Microsoft.Win32;

namespace CS204 {

    // This is from earlier Windows so try only on Virtual Machine

    public class MaxConnectBacklog {
        String path = "SYSTEM\\CurrentControlSet\\Services\\AFD\\Parameters";

        public void Add() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                key?.SetValue("EnableDynamicBacklog", "1", RegistryValueKind.DWord);
                key?.SetValue("MinimumDynamicBacklog", "20", RegistryValueKind.DWord);
                key?.SetValue("MaximumDynamicBacklog", "1000", RegistryValueKind.DWord);
                key?.SetValue("DynamicBacklogGrowthDelta", "10", RegistryValueKind.DWord);
                key?.Close();
            }
        }

        public void Remove() {

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true)) {
                if (key?.GetValue("EnableDynamicBacklog") == null &&
                    key?.GetValue("MinimumDynamicBacklog") == null &&
                    key?.GetValue("MaximumDynamicBacklog") == null &&
                    key?.GetValue("DynamicBacklogGrowthDelta") == null) return;

                key.DeleteValue("EnableDynamicBacklog");
                key.DeleteValue("MinimumDynamicBacklog");
                key.DeleteValue("MaximumDynamicBacklog");
                key.DeleteValue("DynamicBacklogGrowthDelta");
                key.Close();
            }
        }
    }
}