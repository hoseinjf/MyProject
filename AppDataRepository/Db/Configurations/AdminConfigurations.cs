using AppDomainCore.Admins.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class AdminConfigurations : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.user)
                .WithOne(x => x.Admins)
                .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData
            //    (
            //        new Admin
            //        {
            //            Id = 1,
            //            Email = "admin@admin.com",
            //            Password = "admin",
            //        }
            //    );
        }
    }
}
