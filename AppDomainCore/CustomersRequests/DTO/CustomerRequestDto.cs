using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Enum;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CustomersRequests.DTO
{
    public class CustomerRequestDto
    {
        public int Id { get; set; }
        public DateTime DateWork { get; set; }
        public string Description { get; set; }
        public List<Photo>? Photo { get; set; } = new List<Photo>();
        public Work Work { get; set; }
        public Customer Customer { get; set; }
        public StatusEnum Status { get; set; }

    }
}
