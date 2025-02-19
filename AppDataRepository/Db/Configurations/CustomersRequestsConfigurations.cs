using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.CustomersRequests.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    internal class CustomersRequestsConfigurations : IEntityTypeConfiguration<CustomersRequest>
    {
        public void Configure(EntityTypeBuilder<CustomersRequest> builder)
        {
            builder.HasOne(x => x.Customer)
                .WithMany(x => x.CustomersRequests)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData
                (
                    new CustomersRequest()
                    {
                        Id = 1,
                        CustomerId = 1,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        Status = StatusEnum.selected,
                        UpdateAt = DateTime.Now,
                        WorkId = 1,
                    }, new CustomersRequest()
                    {
                        Id = 2,
                        CustomerId = 2,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        Status = StatusEnum.progress,
                        UpdateAt = DateTime.Now,
                        WorkId = 2,
                    }, new CustomersRequest()
                    {
                        Id = 3,
                        CustomerId = 3,
                        CreateAt = DateTime.Now,
                        DateWork = DateTime.Now,
                        Description = "Description",
                        Status = StatusEnum.waiting,
                        UpdateAt = DateTime.Now,
                        WorkId = 3,
                    }
                );
        }
    }
}
