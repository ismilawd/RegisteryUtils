using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RegisteryApi.Registery
{
    public class RegistryManager
    {
        public static bool HavePermissionsOnKey(RegistryPermissionAccess accessLevel, string key)
        {
            try
            {
                RegistryPermission r = new RegistryPermission(accessLevel, key);
                r.Demand();
                return true;
            }
            catch (SecurityException)
            {
                return false;
            }
        }

        public static bool CanWriteKey(string key)
        {
            try
            {
                RegistryPermission r = new RegistryPermission(RegistryPermissionAccess.Write, key);
                r.Demand();
                return true;
            }
            catch (SecurityException)
            {
                return false;
            }
        }

        public static bool CanReadKey(string key)
        {
            try
            {
                RegistryPermission r = new RegistryPermission(RegistryPermissionAccess.Read, key);
                r.Demand();
                return true;
            }
            catch (SecurityException)
            {
                return false;
            }
        }
        public static RegistryKey[] GetRootKeys()
        {
            return new RegistryKey[]{
                Registry.ClassesRoot,
                Registry.CurrentUser,
                Registry.LocalMachine,
                Registry.Users,
                Registry.CurrentConfig
            };
        }
        public static RegistryKey[] GetRegistryKeys(string path)
        {
            if (path == "") return GetRootKeys();
            string baseName = path.Split('\\')[0];
            RegistryKey baseKey = GetBaseKeyByName(baseName);
            if (baseKey is null)
                throw new UserHandledException("مسیر وارد شده صحیح نمیباشد.");
            path = path.Replace(baseName, "");
            if (path == "")
                return GetRegistryKeys(baseKey, baseKey.GetSubKeyNames());
            if (path[0] == '\\') path = path.Remove(0, 1);
            baseKey = baseKey.OpenSubKey(path);
            return GetRegistryKeys(baseKey, baseKey.GetSubKeyNames());
        }

        public static RegistryKey GetRegistryKey(RegistryKey baseKey, string name)
        {
            return baseKey.OpenSubKey(name);
        }
        public static RegistryKey[] GetRegistryKeys(RegistryKey baseKey, string[] names)
        {
            List<RegistryKey> keys = new List<RegistryKey>();
            foreach (string item in names)
            {
                if (HavePermissionsOnKey(RegistryPermissionAccess.AllAccess, $"{baseKey.Name}\\{item}"))
                    keys.Add(baseKey.OpenSubKey(item));
            }
            return keys.ToArray();
        }
        public static RegistryKey GetBaseKeyByName(string name)
        {
            return GetRootKeys().Where(key => key.Name == name).FirstOrDefault();
        }
    }
}
