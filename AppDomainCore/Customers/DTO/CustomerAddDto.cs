using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.Users.Enum;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers.DTO
{
    public class CustomerAddDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? UserName { get; set; }


        [Required]
        [EmailAddress]
        [Display(Name = "ایمیل")]
        public string Email { get; set; }


        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "رمزعبور")]
        public string Password { get; set; }


        public EnumRole UserRole { get; set; } = EnumRole.Customer;


        public string Address { get; set; }
        public Photo? Photo { get; set; }
        public IFormFile? Pic { get; set; }
        public string Phone { get; set; }
        public int? CityId { get; set; }
    }
}
