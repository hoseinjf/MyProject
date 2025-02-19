using AppDomainCore.Provinces.Entity;
using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Admins.Entity
{
    public class Admin
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User user { get; set; }
    }
}
