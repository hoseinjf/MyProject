using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.CustomersRequests.Enum;
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

            builder.HasData
                (
                    new ExpertsRequest()
                    {
                        Id = 1,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        UpdateAt = DateTime.Now,
                        ExpertId = 1,
                        CustomersRequestId = 1,
                        Price = 1000,
                    }, new ExpertsRequest()
                    {
                        Id = 2,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        UpdateAt = DateTime.Now,
                        ExpertId = 2,
                        CustomersRequestId = 2,
                        Price = 1000,
                    }, new ExpertsRequest()
                    {
                        Id = 3,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        UpdateAt = DateTime.Now,
                        ExpertId = 3,
                        CustomersRequestId = 3,
                        Price = 1000,
                    }
                );

        }
    }
}
