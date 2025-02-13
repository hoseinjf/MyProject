using AppDomainCore.Comments.Entity;
using AppDomainCore.Customers;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.ExpertsRequests.Entity
{
    public class ExpertsRequest
    {
        public int Id { get; set; }
        public DateTime DateWork { get; set; }
        public string Description { get; set; }
        public int CustomersRequestId { get; set; }
        public CustomersRequest CustomersRequest { get; set; }
        public int ExpertId { get; set; }
        public Expert Expert { get; set; }
        public double Price { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
