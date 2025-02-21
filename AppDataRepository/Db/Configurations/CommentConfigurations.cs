using AppDomainCore.Comments.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class CommentConfigurations : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Customers)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Experts)
                .WithMany(x => x.Comments)
                .HasForeignKey(x => x.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData
                (
                    new Comment()
                    {
                        Id = 1,
                        Title = "Title",
                        Description = "Description",
                        CustomersId = 1,
                        CreateAt = DateTime.Now,
                        ExpertId = 1,
                        IsActive = true,
                        UpdateAt = DateTime.Now,
                        WorkScore = 4,
                    },
                    new Comment()
                    {
                        Id = 2,
                        Title = "Title",
                        Description = "Description",
                        CustomersId = 2,
                        CreateAt = DateTime.Now,
                        ExpertId = 2,
                        IsActive = true,
                        UpdateAt = DateTime.Now,
                        WorkScore = 3,
                    },
                    new Comment()
                    {
                        Id = 3,
                        Title = "Title",
                        Description = "Description",
                        CustomersId = 3,
                        CreateAt = DateTime.Now,
                        ExpertId = 3,
                        IsActive = true,
                        UpdateAt = DateTime.Now,
                        WorkScore = 5,
                    }
                );
        }
    }
}
