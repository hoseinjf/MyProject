using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.SubCategorys.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Works.DTO
{
    public class WorkDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Photo? Photo { get; set; }
        public int? Viwe { get; set; }
        public string Description { get; set; }
        public double CorePrice { get; set; }
        public int SubCategoryId { get; set; }
        public IFormFile? Pic { get; set; }

    }
}
