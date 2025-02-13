using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Roles.Entity
{
    public class Role
    {
        public int Id { get; set; }
        public string RoleName { get; set; }
        //public User? Users{ get; set; }
        //public Admin? Admin { get; set; }
        //public Customer? Customer { get; set; }
        //public Expert? Expert { get; set; }
        //public int UserId { get; set; }
        //public int CustomerId { get; set; }
        //public int ExpertId { get; set; }
        //public int AdminId { get; set; }
    }
}
