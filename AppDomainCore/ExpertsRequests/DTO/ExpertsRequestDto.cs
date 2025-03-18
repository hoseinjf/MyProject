using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Enum;
using AppDomainCore.Experts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.Works.Entity;
using static System.Net.Mime.MediaTypeNames;

namespace AppDomainCore.ExpertsRequests.DTO
{
    public class ExpertsRequestDto
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public Customer Customer { get; set; }
        public Work Work { get; set; }
        public Expert? Expert { get; set; }
        public Province City { get; set; }
        public CustomersRequest? CustomersRequest { get; set; }
        public int? CustomersRequestId { get; set; }
        public StatusEnum Status { get; set; }
        public DateTime DateWork { get; set; }
        public DateTime CreateAt { get; set; }
        public double Price { get; set; }

    }
}
