﻿using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.SubCategorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Works.Entity
{
    public class Work
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Photo? Photo { get; set; }
        public int? PhotoId { get; set; }
        public int? Viwe { get; set; }
        public string Description { get; set; }
        public double CorePrice { get; set; }
        public int SubCategoryId { get; set; }
        public SubCategory SubCategory { get; set; }
        public List<Expert>? Experts { get; set; } = new List<Expert>();
        public List<CustomersRequest>? Customers { get; set; } = new List<CustomersRequest>();
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public bool IsDelete { get; set; } = false;
    }
}
