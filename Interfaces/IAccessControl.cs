using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Models;

namespace UserPermissions.Interfaces
{
    public interface IAccessControl
    {
        public List<Permission> GetPermissions();
        public void AddDirectorySecurity(string DirectoryName, string Account,
            FileSystemRights Rights, AccessControlType ControlType);

        public void RemoveDirectorySecurity(string DirectoryName, string Account,
            FileSystemRights Rights, AccessControlType ControlType);
    }
}
