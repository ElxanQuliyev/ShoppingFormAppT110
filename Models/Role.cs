using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormAppT110.Models
{
    public partial class Role
    {
        public Role()
        {
            RoleToUsers = new HashSet<RoleToUser>();
        }

        public int RoleId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<RoleToUser> RoleToUsers { get; set; }
    }
}
