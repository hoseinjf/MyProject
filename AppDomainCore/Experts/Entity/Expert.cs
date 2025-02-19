using AppDomainCore.Comments.Entity;
using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.Provinces.Entity;
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

        public List<Work>? Works { get; set; } = new List<Work>();
        public List<ExpertsRequest>? ExpertsRequests { get; set; } = new List<ExpertsRequest>();
        public string? Biography { get; set; }
        public int? Score { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public List<Comment>? Comments { get; set; } = new List<Comment>();
    }
}
