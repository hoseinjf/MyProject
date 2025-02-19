using AppDomainCore.Experts.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class ExpertConfigurations : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.HasMany(x => x.Works)
                   .WithMany(x => x.Experts);

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Experts)
                   .HasForeignKey(x => x.ExpertId)
                   .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData
            //(
            //    new Expert
            //    {
            //        Id = 1,
            //        Email = "hasn@hasan.com",
            //        Password = "hasan",
            //    }
            //);
        }
    }
}
