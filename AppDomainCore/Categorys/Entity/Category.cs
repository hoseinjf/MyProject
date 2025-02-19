using AppDomainCore.Photos.Entity;
using AppDomainCore.SubCategorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Categorys.Entity
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Photo? Photo { get; set; }
        public int? PhotoId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;
        public List<SubCategory>? subCategories { get; set; } = new List<SubCategory>();
    }
}
