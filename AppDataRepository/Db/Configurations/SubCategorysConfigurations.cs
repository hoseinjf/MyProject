using AppDomainCore.Photos.Entity;
using AppDomainCore.SubCategorys.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db.Configurations
{
    public class SubCategorysConfigurations : IEntityTypeConfiguration<SubCategory>
    {
        public void Configure(EntityTypeBuilder<SubCategory> builder)
        {
            builder.HasKey(c => c.Id);

            builder.HasMany(x => x.works)
                   .WithOne(x => x.SubCategory)
                   .HasForeignKey(x => x.SubCategoryId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData
                (
                    new SubCategory
                    {
                        Id = 1,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "بنایی",
                    },
                    new SubCategory
                    {
                        Id = 2,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "دکوراسیون",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 3,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "نقاشی ساختمان",
                    },
                    new SubCategory
                    {
                        Id = 4,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "درب و پنجره",
                    },
                    new SubCategory
                    {
                        Id = 5,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "آهنگری و جوشکاری",
                    },
                    new SubCategory
                    {
                        Id = 6,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 1,
                        Photo = new Photo(),
                        Title = "باغبانی",
                    },

                    //****************************************************
                    // 2 -------------------------------------------------
                    //****************************************************
                    new SubCategory
                    {
                        Id = 7,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 2,
                        Photo = new Photo(),
                        Title = "سرمایش و گرمایش",
                    },
                    new SubCategory
                    {
                        Id = 8,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 2,
                        Photo = new Photo(),
                        Title = "لوله کشی",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 9,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 2,
                        Photo = new Photo(),
                        Title = "برقو الکترونیک",
                    },
                    new SubCategory
                    {
                        Id = 10,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 2,
                        Photo = new Photo(),
                        Title = "تلفن و سانترال",
                    },

                    //****************************************************
                    // 3 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 11,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 3,
                        Photo = new Photo(),
                        Title = "خودرو",
                    },

                    //****************************************************
                    // 4 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 12,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 4,
                        Photo = new Photo(),
                        Title = "اسبابکشی",
                    },
                    new SubCategory
                    {
                        Id = 13,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 4,
                        Photo = new Photo(),
                        Title = "حمل بار",
                    }
                    ,

                    //****************************************************
                    // 5 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 14,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 5,
                        Photo = new Photo(),
                        Title = "لوازم آشپزخانه",
                    },
                    new SubCategory
                    {
                        Id = 15,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 5,
                        Photo = new Photo(),
                        Title = "لوازم شست و شو",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 16,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 5,
                        Photo = new Photo(),
                        Title = "لوازم صوتی و تصویری",
                    },

                    //****************************************************
                    // 6 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 17,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 6,
                        Photo = new Photo(),
                        Title = "ماشین آلات اداری",
                    },
                    new SubCategory
                    {
                        Id = 18,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 6,
                        Photo = new Photo(),
                        Title = "مبلمان اداری",
                    }
                    ,

                    //****************************************************
                    // 7 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 19,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 7,
                        Photo = new Photo(),
                        Title = "نظافت",
                    },
                    new SubCategory
                    {
                        Id = 20,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 7,
                        Photo = new Photo(),
                        Title = "خشک شویی و اتوشویی",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 21,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 7,
                        Photo = new Photo(),
                        Title = "قالی شویی و مبل شویی",
                    },
                    new SubCategory
                    {
                        Id = 22,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 7,
                        Photo = new Photo(),
                        Title = "سمپاشی",
                    },


                    //****************************************************
                    // 8 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 23,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 8,
                        Photo = new Photo(),
                        Title = "موبایل و تبلت",
                    },
                    new SubCategory
                    {
                        Id = 24,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 8,
                        Photo = new Photo(),
                        Title = "خدمات کامپیوتری",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 25,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 8,
                        Photo = new Photo(),
                        Title = "امنیت و شبکه",
                    },


                    //****************************************************
                    // 9 -------------------------------------------------
                    //****************************************************

                    new SubCategory
                    {
                        Id = 26,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 9,
                        Photo = new Photo(),
                        Title = "معاینه پزشک",
                    },
                    new SubCategory
                    {
                        Id = 27,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 9,
                        Photo = new Photo(),
                        Title = "داروخانه",
                    }
                    ,
                    new SubCategory
                    {
                        Id = 28,
                        CreateAt = DateTime.UtcNow,
                        UpdateAt = DateTime.UtcNow,
                        CategoryId = 9,
                        Photo = new Photo(),
                        Title = "مشاوره",
                    }
                );

        }
    }
}
