﻿using System;
using System.Collections.Generic;
using System.DirectoryServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Interfaces;

namespace UserPermissions.Data
{
    public class GroupManager : IGroupManager
    {
        public Task<bool> AddUserToGroup(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CreateGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteGroup(string grupName)
        {
            DirectoryEntry entry = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            Console.WriteLine("WinNT://" + Environment.MachineName + ",computer");
            DirectoryEntry group = new DirectoryEntry($"WinNT://{Environment.MachineName}/{grupName},group");
            entry.Children.Remove(group);

            return true;
        }
    }
}