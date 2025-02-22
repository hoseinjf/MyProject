using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers.DTO
{
    public class CustomerAddDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public Photo? Photo { get; set; }
        public IFormFile? Pic { get; set; }
        public string Phone { get; set; }
        public int? CityId { get; set; }
        public List<Province>? provinces { get; set; }
    }
}
