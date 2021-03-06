using System;
using System.Collections.Generic;

#nullable disable

namespace ShoppingFormAppT110.Models
{
    public partial class User
    {
        public User()
        {
            Orders = new HashSet<Order>();
            RoleToUsers = new HashSet<RoleToUser>();
        }

        public int UserId { get; set; }
        public string Fullname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<RoleToUser> RoleToUsers { get; set; }
    }
}
