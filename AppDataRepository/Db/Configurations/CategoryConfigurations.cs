using AppDomainCore.Categorys.Entity;
using AppDomainCore.Photos.Entity;
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
    public class CategoryConfigurations : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.HasKey(x => x.Id);

            builder.HasMany(x => x.subCategories)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData
                (
                    new Category
                    {
                        Id = 1,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        //                        //Photo = new Photo(),
                        Title = "دکوراسیون ساختمان",
                    },
                    new Category
                    {
                        Id = 2,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "تاسیسات ساختمان",
                    }
                    ,
                    new Category
                    {
                        Id = 3,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "وسیله نقلیه",
                    },
                    new Category
                    {
                        Id = 4,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "اسبابکشی و باربری",
                    },
                    new Category
                    {
                        Id = 5,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "لوازم خانگی",
                    },
                    new Category
                    {
                        Id = 6,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "خدمات اداری",
                    },
                    new Category
                    {
                        Id = 7,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "نظافت و بهداشت",
                    },
                    new Category
                    {
                        Id = 8,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "دیجیتال و نرم افزار",
                    },
                    new Category
                    {
                        Id = 9,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                                                //Photo = new Photo(),
                        Title = "پزشکی و سلامت",
                    }
                );
        }
    }
}
