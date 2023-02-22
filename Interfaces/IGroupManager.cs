using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Models;

namespace UserPermissions.Interfaces
{
    public interface IGroupManager
    {
        public bool CreateGroup(string groupName);
        public bool DeleteGroup(string groupName); 
        public bool AddUserToGroup(string username, string groupname);
        public List<string> GetAllGroups(); 
    }
}
