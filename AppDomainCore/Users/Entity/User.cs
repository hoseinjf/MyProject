using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Users.Entity
{
    public class User:IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? ProvinceId { get; set; }
        public Province? Province { get; set; }
        public string? AccountNumber { get; set; }
        public string? AccountCode { get; set; }
        public double? Balance { get; set; }
        public string? Address { get; set; }
        public Photo? Photo { get; set; }
        public int PhotoId { get; set; }
        public string? Phone { get; set; }

        public List<Admin>? Admins { get; set; } = new List<Admin>();
        public List<Customer>? Customers { get; set; } = new List<Customer>();
        public List<Expert>? Experts { get; set; } = new List<Expert>();
    }
}
