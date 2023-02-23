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
        public void AddDirectorySecurity(string DirectoryName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(DirectoryName);

            // Get a DirectorySecurity object that represents the
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings.
            dSecurity.AddAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);
        }

        public void RemoveDirectorySecurity(string DirectoryName, string Account, FileSystemRights Rights, AccessControlType ControlType)
        {
            // Create a new DirectoryInfo object.
            DirectoryInfo dInfo = new DirectoryInfo(DirectoryName);

            // Get a DirectorySecurity object that represents the
            // current security settings.
            DirectorySecurity dSecurity = dInfo.GetAccessControl();

            // Add the FileSystemAccessRule to the security settings.
            dSecurity.RemoveAccessRule(new FileSystemAccessRule(Account,
                                                            Rights,
                                                            ControlType));

            // Set the new access settings.
            dInfo.SetAccessControl(dSecurity);
        }

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
