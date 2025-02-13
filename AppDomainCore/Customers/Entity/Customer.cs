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

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCode { get; set; }
        public double Balance { get; set; }
        public string? Address { get; set; }
        public string? Photo { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        //public int UserRoleId { get; set; }
        //public Role? UserRole { get; set; }
        public string? Phone { get; set; }
        //public int UserId { get; set; }
        //public User? User { get; set; }
        public List<CustomersRequest>? CustomersRequests { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
