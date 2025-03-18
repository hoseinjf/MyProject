using AppDomainCore.Photos.Entity;
using AppDomainCore.Users.Enum;
using AppDomainCore.Works.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.Provinces.Entity;

namespace AppDomainCore.Experts.DTO
{
    public class ExpertUpdateProfileDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Photo? Photo { get; set; }
        public IFormFile? Pic { get; set; }
        public string Phone { get; set; }
        public int? CityId { get; set; }
        public Province? City { get; set; }
        public string? Biography { get; set; }
        public double? Balance { get; set; }
        public List<int>? WorksId { get; set; } = new List<int>();

		public List<Work>? Works { get; set; } = new List<Work>();
    }
}
