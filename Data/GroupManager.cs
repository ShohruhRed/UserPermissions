using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.Linq;
using UserPermissions.Interfaces;
using UserPermissions.Models;

namespace UserPermissions.Data
{
    public class GroupManager : IGroupManager
    {    
        public bool AddUserToGroup(string username)
        {
            var userManager = new UserManager();
            DirectoryEntry AD = new DirectoryEntry("WinNT://" +
            Environment.MachineName + ",computer");
            DirectoryEntry grp;

            var uExists = userManager.FindUser(username);

            if (!uExists)
            {
                return false;
            }
            var user = userManager.GetUser(username);

          

            grp = AD.Children.Find("Гости", "group");
            if (grp != null) { grp.Invoke("Add", new object[] { user.Path.ToString() }); }
            else
                return false;

            return true;          

        }

        public bool CreateGroup(string groupName)
        {
            var groups = GetAllGroups();
            if (groups.Contains(groupName))
            {
                return false;
            }

            var ad = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry newGroup = ad.Children.Add(groupName, "group");
            newGroup.Invoke("Put", new object[] { "Description", "Test Group from .NET" });
            newGroup.CommitChanges();

            return true;
        }

        public bool DeleteGroup(string grupName)
        {
            DirectoryEntry entry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            Console.WriteLine("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry group = new DirectoryEntry($"WinNT://{Environment.MachineName}/{grupName},group");
            entry.Children.Remove(group);

            return true;
        }

        public List<string> GetAllGroups()
        {
            var users = new List<string>();
            var groups = new List<string>();
            var usersWithGroups = new List<Group>();
            string path = string.Format("WinNT://{0},computer", Environment.MachineName);

            using (DirectoryEntry computerEntry = new DirectoryEntry(path))
            {
                IEnumerable<string> userNames = computerEntry.Children
                    .Cast<DirectoryEntry>()
                    .Where(childEntry => childEntry.SchemaClassName == "User")
                    .Select(userEntry => userEntry.Name);

                foreach (var user in userNames)
                {
                    users.Add(user);
                }
            }        
           

            return users;
        }
    }
}
