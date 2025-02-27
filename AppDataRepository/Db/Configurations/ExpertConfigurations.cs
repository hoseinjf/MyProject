using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace AppDataRepository.Db.Configurations
{
    public class ExpertConfigurations : IEntityTypeConfiguration<Expert>
    {
        public void Configure(EntityTypeBuilder<Expert> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.Works)
                   .WithMany(x => x.Experts);

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Experts)
                   .HasForeignKey(x => x.ExpertId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData
            (
                new Expert
                {
                    Id = 1,
                    Biography = "asd",
                    UserId = 2,
                    Score = 0,

                },
                new Expert
                {
                    Id = 2,
                    Biography = "ased",
                    UserId = 3,
                    Score = 0,

                },
                new Expert 
                {
                    Id = 3,
                    Biography = "asdsd",
                    UserId = 4,
                    Score = 0,

                }

            );
        }
    }
}
