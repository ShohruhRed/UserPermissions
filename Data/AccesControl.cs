using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using UserPermissions.Interfaces;
using UserPermissions.Models;

namespace UserPermissions.Data
{
    class AccesControl : IAccessControl
    {
        public List<Permission> GetPermissions()
        {
            var permissions = new List<Permission>();

            string filename = "C:\\pzs\\test.txt";

            FileStream stream = File.Open(filename, FileMode.Open);
            FileSecurity securityDescriptor = stream.GetAccessControl();
            AuthorizationRuleCollection rules =
                  securityDescriptor.GetAccessRules(true, true,
                        typeof(NTAccount));

            foreach (AuthorizationRule rule in rules)
            {
                var fileRule = rule as FileSystemAccessRule;
                var obj = new Permission
                {
                    AccessType = fileRule.AccessControlType.ToString(),
                    Rights = fileRule.FileSystemRights.ToString(),
                    Identity = fileRule.IdentityReference.Value.ToString()
                };

                permissions.Add(obj);
            }           

            return permissions;
        }
    }
}
