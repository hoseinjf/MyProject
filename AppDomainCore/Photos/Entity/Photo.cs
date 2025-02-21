using AppDomainCore.Categorys.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Photos.Entity
{
    public class Photo
    {
        public int Id { get; set; }
        public string Src { get; set; }

        public User? User { get; set; }
        public CustomersRequest? Customer { get; set; }
        public Category? Category { get; set; }
        public SubCategory? SubCategory { get; set; }
        public Work? Work { get; set; }
    }
}
