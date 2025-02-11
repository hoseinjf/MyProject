using AppDomainCore.Provinces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Users
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProvinceId { get; set; }
        public Province Province { get; set; }
        public string AccountNumber { get; set; }
        public string AccountCode { get; set; }
        public double Balance { get; set; }
        public string Address { get; set; }
        public string Photo { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
