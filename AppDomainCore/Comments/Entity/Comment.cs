using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.ExpertsRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Comments.Entity
{
    public class Comment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CustomersId { get; set; }
        public Customer? Customers { get; set; }
        public int ExpertId { get; set; }
        public Expert? Experts { get; set; }
        public bool IsActive { get; set; } = false;
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;
        public int WorkScore { get; set; }

    }
}
