using AppDomainCore.Customers.Entity;
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
    public class CustomerConfigurations : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.CustomersRequests)
                   .WithOne(x => x.Customer)
                   .HasForeignKey(x => x.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(x => x.Comments)
                   .WithOne(x => x.Customers)
                   .HasForeignKey(x => x.CustomersId)
                   .OnDelete(DeleteBehavior.Restrict);

            //builder.HasData
            //(
            //    new Customer
            //    {
            //        Id = 1,
            //        Email = "ali@ali.com",
            //        Password = "ali",
            //    }
            //);

        }
    }
}
