using AppDomainCore.Customers;
using AppDomainCore.Works;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CustomersRequests
{
    public class CustomersRequest
    {
        public int Id { get; set; }
        public DateTime DateWork { get; set; }
        public DateTime HourWork { get; set; }
        public string Description { get; set; }
        public string Photo { get; set; }
        public int WorkId { get; set; }
        public Work Work { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Status { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
