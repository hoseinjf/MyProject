using AppDomainCore.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategorys
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
