using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Models;

namespace UserPermissions.Interfaces
{
    internal interface IUserManager
    {
        public bool CreateUser(string userName, string password);
        public bool DeleteUser(string username);
        public bool FindUser(string username);
        public DirectoryEntry GetUser(string username);
    }
}
