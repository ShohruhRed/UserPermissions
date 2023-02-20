using System;
using System.DirectoryServices;
using System.Threading.Tasks;
using UserPermissions.Interfaces;

namespace UserPermissions.Data
{
    public class UserManager : IUserManager
    {
        public async Task<bool> CreateUser(string userName, string password)
        {
            DirectoryEntry AD = new DirectoryEntry("WinNT://" +
            Environment.MachineName + ",computer");
            DirectoryEntry NewUser = AD.Children.Add(userName, "user");
            NewUser.Invoke("SetPassword", new object[] { password });
            NewUser.Invoke("Put", new object[] { "Description", "Test User from .NET" });
            NewUser.CommitChanges();
            DirectoryEntry grp;

            grp = AD.Children.Find("Guests", "group");

            if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }

            return true;
        }

        public async Task<bool> DeleteUser(string username)
        {
            DirectoryEntry localDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString());
            DirectoryEntries users = localDirectory.Children;
            DirectoryEntry user = users.Find(username);

            if (user == null) return false;
            users.Remove(user);

            return true;
        }
    }    
}