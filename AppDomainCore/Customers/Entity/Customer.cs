using AppDomainCore.Comments.Entity;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.Roles.Entity;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers.Entity
{
    public class Customer
    {
        public int Id { get; set; }
        //public int UserRoleId { get; set; }
        //public Role? UserRole { get; set; }
        public string? Phone { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<CustomersRequest>? CustomersRequests { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
