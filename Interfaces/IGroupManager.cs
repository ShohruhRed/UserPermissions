using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPermissions.Interfaces
{
    public interface IGroupManager
    {
        public Task<bool> CreateGroup(string groupName);
        public Task<bool> DeleteGroup(string grupName); 
        public Task<bool> AddUserToGroup(string username);
    }
}
