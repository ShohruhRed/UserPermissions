using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using UserPermissions.Interfaces;
using UserPermissions.Models;

namespace UserPermissions.Data
{
    public class UserManager : IUserManager
    {
        public bool CreateUser(string userName, string password)
        {
            DirectoryEntry AD = new DirectoryEntry("WinNT://" +
            Environment.MachineName + ",computer");
            DirectoryEntry NewUser = AD.Children.Add(userName, "user");
            NewUser.Invoke("SetPassword", new object[] { password });
            NewUser.Invoke("Put", new object[] { "Description", "Test User from .NET" });
            NewUser.CommitChanges();
            DirectoryEntry grp;

            grp = AD.Children.Find("Гости", "group");

            if (grp != null) { grp.Invoke("Add", new object[] { NewUser.Path.ToString() }); }
            else
            {
                return false;
            }

            return true;
        }

        public bool DeleteUser(string username)
        {
            DirectoryEntry localDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString());
            DirectoryEntries users = localDirectory.Children;

            var uExists = FindUser(username);

            if (!uExists)
            {                
                return false;
            }
            var user = GetUser(username);           


            users.Remove(user);

            return true;
        }

        public DirectoryEntry GetUser(string username)
        {
            DirectoryEntry localDirectory = new DirectoryEntry("WinNT://" + Environment.MachineName.ToString());
            DirectoryEntries users = localDirectory.Children;

            var uExists = FindUser(username);
            if (!uExists)
            {
                throw new ArgumentException();
            }
            DirectoryEntry user = users.Find(username);

            return user;
            
        }

        public bool FindUser(string username)
        {
            List<string> users = new List<string>();
            var path =
                string.Format("WinNT://{0},computer", Environment.MachineName);

            using (var computerEntry = new DirectoryEntry(path))
                foreach (DirectoryEntry childEntry in computerEntry.Children)
                    if (childEntry.SchemaClassName == "User")
                        users.Add(childEntry.Name);

            var userExists = users.Contains(username);

            if (!userExists) return false;

            return true;
        }

        
    }    
}