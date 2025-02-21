using AppDomainCore.Photos.Entity;
using AppDomainCore.Works.Entity;
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
    internal class WorksConfigurations : IEntityTypeConfiguration<Work>
    {
        public void Configure(EntityTypeBuilder<Work> builder)
        {
            builder.HasKey(x => x.Id);

            builder
                .HasMany(x => x.Customers)
                .WithOne(x => x.Work)
                .HasForeignKey(x => x.WorkId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasMany(x => x.Experts)
                .WithMany(x => x.Works);

            builder.HasData
                (

                    new Work
                    {
                        Id = 1,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 1,
                                                //Photo = new Photo(),
                        Title = "پی ریزی",
                        CorePrice = 500,
                        Description = "انجام انواع امور پی ریزی"
                    },

                    new Work
                    {
                        Id = 2,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 1,
                                                //Photo = new Photo(),
                        Title = "بلوک گذاری و دیوار چینی",
                        CorePrice = 1000,
                        Description = "انجام انواع امور بلوک گذاری و دیوار چینی"
                    },

                    new Work
                    {
                        Id = 3,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 1,
                                                //Photo = new Photo(),
                        Title = "کف ساختمان",
                        CorePrice = 600,
                        Description = "انجام انواع امور مرتبط با کف ساختمان"
                    },

                    new Work
                    {
                        Id = 4,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 1,
                                                //Photo = new Photo(),
                        Title = "نوسازی",
                        CorePrice = 6000,
                        Description = "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر"
                    },

                    new Work
                    {
                        Id = 5,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 1,
                                                //Photo = new Photo(),
                        Title = "سیمان کاری",
                        CorePrice = 500,
                        Description = "انجام انواع امور سیمان کاری"
                    },

                    new Work
                    {
                        Id = 6,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 2,
                                                //Photo = new Photo(),
                        Title = "دکور آشپزخانه",
                        CorePrice = 500,
                        Description = "انجام انواع امور دکور آشپزخانه"
                    },

                    new Work
                    {
                        Id = 7,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 2,
                                                //Photo = new Photo(),
                        Title = "دکور حال و پذیرایی",
                        CorePrice = 580,
                        Description = "انجام انواع امور دکور حال و پذیرایی"
                    },

                    new Work
                    {
                        Id = 8,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 2,
                                                //Photo = new Photo(),
                        Title = "دکور اتاق خواب",
                        CorePrice = 400,
                        Description = "انجام انواع امور دکور اتاق خواب"
                    },

                    new Work
                    {
                        Id = 9,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 2,
                                                //Photo = new Photo(),
                        Title = "طراحی و دیزاین ساختمان",
                        CorePrice = 800,
                        Description = "انجام انواع امور طراحی و دیزاین ساختمان"
                    },

                    new Work
                    {
                        Id = 10,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 2,
                                                //Photo = new Photo(),
                        Title = "معماری داخلی",
                        CorePrice = 1500,
                        Description = "انجام انواع امور معماری داخلی"
                    },



                    new Work
                    {
                        Id = 11,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 3,
                                                //Photo = new Photo(),
                        Title = "نقاشی داخل ساختمان",
                        CorePrice = 800,
                        Description = "انجام انواع امور نقاشی داخل ساختمان"
                    },

                    new Work
                    {
                        Id = 12,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 3,
                                                //Photo = new Photo(),
                        Title = "نقاشی خارج ساختمان",
                        CorePrice = 300,
                        Description = "انجام انواع امور نقاشی خارج ساختمان"
                    },



                    new Work
                    {
                        Id = 13,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 4,
                                                //Photo = new Photo(),
                        Title = "تعمیرات درب و پنجره",
                        CorePrice = 200,
                        Description = "انجام انواع امور تعمیرات درب و پنجره"
                    },
                    new Work
                    {
                        Id = 14,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 4,
                                                //Photo = new Photo(),
                        Title = "سفارش درب و پنجره",
                        CorePrice = 800,
                        Description = "انجام انواع امور سفارش درب و پنجرهن"
                    },



                    new Work
                    {
                        Id = 15,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 5,
                                                //Photo = new Photo(),
                        Title = "آهنگری و جوشکاری لوازم و غیره",
                        CorePrice = 800,
                        Description = "انجام انواع امور آهنگری و جوشکاری لوازم و غیره"
                    },
                    new Work
                    {
                        Id = 16,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 5,
                                                //Photo = new Photo(),
                        Title = "آهنگری و جوشکاری ساختمانی",
                        CorePrice = 800,
                        Description = "انجام انواع امور آهنگری و جوشکاری ساختمانی"
                    },


                    new Work
                    {
                        Id = 17,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 6,
                                                //Photo = new Photo(),
                        Title = "باغبانی ساختمان ها ومجتمع ها ",
                        CorePrice = 500,
                        Description = "انجام انواع امور باغبانی ساختمان ها ومجتمع ها"
                    },
                    new Work
                    {
                        Id = 18,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        SubCategoryId = 6,
                                                //Photo = new Photo(),
                        Title = "باغبانی فضای شهری و سازمان ها",
                        CorePrice = 800,
                        Description = "انجام انواع امور باغبانی فضای شهری و سازمان ها"
                    }
                );

        }
    }
}
