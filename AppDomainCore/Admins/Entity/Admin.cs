using AppDomainCore.Provinces.Entity;
using AppDomainCore.Roles.Entity;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Admins.Entity
{
    public class Admin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCode { get; set; }
        public double? Balance { get; set; }
        public string? Address { get; set; }
        public string? Photo { get; set; }

        //public int UserRoleId { get; set; }
        //public Role? UserRole { get; set; }
        //public int UserId { get; set; }
        //public User? user { get; set; }
    }
}
