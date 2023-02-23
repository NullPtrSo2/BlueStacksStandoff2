using System;
using Microsoft.Win32;

namespace StandoffBlueStacks
{
    static class RegistryUtils
    {
        public static void SetValue(string subKey, string key, object value)
        {
            using (RegistryKey blueStacksConfig = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(subKey, true))
            {
                if (blueStacksConfig != null)
                {
                    blueStacksConfig.SetValue(key, value);
                }
                else
                {
                    throw new NullReferenceException("Ветка реестра не найдена");
                }
            }
        }

        public static object GetValue(string subKey, string key)
        {
            using (RegistryKey blueStacksConfig = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(subKey, true))
            {
                if (blueStacksConfig != null)
                {
                    return blueStacksConfig.GetValue(key);
                }
                else
                {
                    throw new NullReferenceException("Ветка реестра не найдена");
                }
            }
        }
    }
}
