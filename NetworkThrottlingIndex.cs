using System;
using Microsoft.Win32;

namespace CS204 {

    public class NetworkThrottlingIndex {

        public void Add() {
            //const string userRoot = "HKEY_LOCAL_MACHINE";
            //const string subkey = "RegistrySetValueExample";
            //const string keyName = userRoot + "\\" + subkey;
            //string[] path = Registry.LocalMachine.;
            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var mykey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true)) {
                mykey?.SetValue("NetworkThrottlingIndex", Int32.MaxValue, RegistryValueKind.DWord);
                mykey?.Close();
            }
        }

        public void Remove() {

            using (var hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            using (var mykey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile", true)) {
                mykey?.SetValue("NetworkThrottlingIndex", 10, RegistryValueKind.DWord);
                mykey?.Close();
            }
        }
    }
}