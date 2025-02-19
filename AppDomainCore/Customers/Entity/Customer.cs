using AppDomainCore.Comments.Entity;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers.Entity
{
    public class Customer
    {
        public int Id { get; set; }

        
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<CustomersRequest>? CustomersRequests { get; set; } = new List<CustomersRequest>();
        public List<Comment>? Comments { get; set; } = new List<Comment>();
    }
}
