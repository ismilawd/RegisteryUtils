using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace RegisteryApi.Registery
{
    public class RegisteryManager
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
    }
}
