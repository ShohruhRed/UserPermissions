using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Models;

namespace UserPermissions.Interfaces
{
    internal interface IUserManager
    {
        public Task<bool> CreateUser(string userName, string password);
        public Task<bool> DeleteUser(string username);
    }
}
