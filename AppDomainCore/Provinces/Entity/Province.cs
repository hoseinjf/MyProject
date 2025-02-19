﻿using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Provinces.Entity
{
    public class Province
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User? User { get; set; }
        public int? UserId { get; set; }
    }
}
