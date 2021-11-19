using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormAppT110.Models
{
    public partial class RoleToUser
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }

        public virtual Role Role { get; set; }
        public virtual User User { get; set; }
    }
}
