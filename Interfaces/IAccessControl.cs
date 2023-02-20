using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserPermissions.Models;

namespace UserPermissions.Interfaces
{
    public interface IAccessControl
    {
        public List<Permission> GetPermissions();
    }
}
