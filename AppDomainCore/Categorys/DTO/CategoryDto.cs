using AppDomainCore.Photos.Entity;
using AppDomainCore.SubCategorys.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Categorys.DTO
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Photo? Photo { get; set; }
        public IFormFile? Pic { get; set; }
        public List<SubCategory>? subCategories { get; set; } = new List<SubCategory>();
    }
}
