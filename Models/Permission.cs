using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserPermissions.Models
{
    class Permission
    {
        public string AccessType { get; set; }
        public string Rights { get; set; }
        public string Identity { get; set; }
    }
}
