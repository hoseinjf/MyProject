using AppDomainCore.Comments.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Enum;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CustomersRequests.Entity
{
    public class CustomersRequest
    {
        public int Id { get; set; }
        public DateTime DateWork { get; set; }
        public string Description { get; set; }
        public List<string?> Photo { get; set; }
        public int WorkId { get; set; }
        public Work Work { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;

    }
}
