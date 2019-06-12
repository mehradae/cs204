using System;
using Microsoft.Win32;

public class TCPackFrequency

{
    String path = "SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces\\{1905e6b4-2e49-4701-aeea-52809bdc9f49}";

    public void Add()
    {

        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true))
        {
            if (key != null)
            {
                key.SetValue("TCPackFrequency", "1", RegistryValueKind.DWord);
                key.SetValue("TCPNoDelay", "1", RegistryValueKind.DWord);
                key.Close();
            }
        }

    }

    public void Remove()
    {
        using (RegistryKey key = Registry.LocalMachine.OpenSubKey(path, true))
        {
            if (key != null)
            {
                if ((key.GetValue("TCPNoDelay") != null) && (key.GetValue("TCPackFrequency") != null))
                {
                    key.DeleteValue("TCPackFrequency");
                    key.DeleteValue("TCPNoDelay");
                    key.Close();
                }
            }
        }
    }
}
}
