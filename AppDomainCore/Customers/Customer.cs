using AppDomainCore.Roles;
using AppDomainCore.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers
{
    public class Customer
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
        public string Phone { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
