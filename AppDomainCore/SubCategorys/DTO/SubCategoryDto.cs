using AppDomainCore.Categorys.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Works.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategorys.DTO
{
    public class SubCategoryDto
    {
        public string Title { get; set; }
        public Photo? Photo { get; set; }
        public IFormFile? Pic { get; set; }
        public List<Work>? works { get; set; } = new List<Work>();
    }
}
