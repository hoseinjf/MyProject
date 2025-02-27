using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Comments.DTO
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Customer Customers { get; set; }
        public Expert Experts { get; set; }
        public bool IsActive { get; set; } = false;
        public int WorkScore { get; set; }

    }
}
