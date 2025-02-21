using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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


        public DateTime? CreateAt  { get; set; }
        public DateTime? UpdateAt  { get; set; }
        public bool IsDelete { get; set; }=false;

        public Photo? Photo { get; set; }
        [ForeignKey(nameof(PhotoId))]
        public int? PhotoId { get; set; }
        public string? Phone { get; set; }

        public Admin? Admins { get; set; }
        public Customer? Customers { get; set; }
        public Expert? Experts { get; set; }
    }
}
