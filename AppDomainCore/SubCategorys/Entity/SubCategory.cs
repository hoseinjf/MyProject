using AppDomainCore.Categorys.Entity;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategorys.Entity
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string? Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Work> works { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
