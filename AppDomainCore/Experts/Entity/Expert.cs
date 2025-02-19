using AppDomainCore.Comments.Entity;
using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.Roles.Entity;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Experts.Entity
{
    public class Expert
    {
        public int Id { get; set; }
        //public int UserRoleId { get; set; }
        //public Role? UserRole { get; set; }
        public string? Phone { get; set; }
        public List<Work>? Works { get; set; }
        public List<ExpertsRequest>? ExpertsRequests { get; set; }
        public string? Biography { get; set; }
        public int? Score { get; set; }
        //public int UserId { get; set; }
        //public User? User { get; set; }
        public List<Comment>? Comments { get; set; }
    }
}
