using AppDomainCore.ExpertsRequests.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class ExpertsRequestsConfigurations : IEntityTypeConfiguration<ExpertsRequest>
    {
        public void Configure(EntityTypeBuilder<ExpertsRequest> builder)
        {
            builder.HasKey(x => x.Id);


        }
    }
}
