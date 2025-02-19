using AppDomainCore.Admins.Entity;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Comments.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.Provinces.Entity;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using AppDomainCore.Photos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Db
{
    public class AppDbContext : IdentityDbContext<User,IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }

        #region dbset
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomersRequest> CustomersRequests { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertsRequest> ExpertsRequests { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Photo> Photo { get; set; }
        #endregion


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region روابط

            #region یوزر

            //modelBuilder.Entity<User>().HasKey(x => x.Id);

            //modelBuilder.Entity<User>()
            //    .HasMany(x => x.Admins)
            //    .WithOne(x => x.user)
            //    .HasForeignKey(x => x.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>()
            //    .HasMany(x => x.Customers)
            //    .WithOne(x => x.User)
            //    .HasForeignKey(x => x.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<User>()
            //    .HasMany(x => x.Experts)
            //    .WithOne(x => x.User)
            //    .HasForeignKey(x => x.UserId)
            //    .OnDelete(DeleteBehavior.Restrict);

            #endregion

            #region رول



            #endregion

            #region زیردسته بندی ها
            modelBuilder.Entity<SubCategory>()
               .HasMany(x => x.works)
               .WithOne(x => x.SubCategory)
               .HasForeignKey(x => x.SubCategoryId)
               .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region خدمات
            modelBuilder.Entity<Work>()
               .HasMany(x => x.Customers)
               .WithOne(x => x.Work)
               .HasForeignKey(x => x.WorkId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Work>()
                .HasMany(x => x.Experts)
                .WithMany(x => x.Works);

            #endregion

            #region مشتری
            modelBuilder.Entity<Customer>()
                .HasMany(x => x.CustomersRequests)
                .WithOne(x => x.Customer)
                .HasForeignKey(x => x.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Customer>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Customers)
                .HasForeignKey(x => x.CustomersId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region کامنت

            #endregion

            #region کارشناس
            modelBuilder.Entity<Expert>()
                .HasMany(x => x.Works)
                .WithMany(x => x.Experts);

            modelBuilder.Entity<Expert>()
                .HasMany(x => x.Comments)
                .WithOne(x => x.Experts)
                .HasForeignKey(x => x.ExpertId)
                .OnDelete(DeleteBehavior.Restrict);
            #endregion

            #region دسته بندی ها

            modelBuilder.Entity<Category>().HasKey(x => x.Id);

            modelBuilder.Entity<Category>()
                .HasMany(x => x.subCategories)
                .WithOne(x => x.Category)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            #endregion


            #endregion

            #region استان ها

            modelBuilder.Entity<Province>().HasData(
                new Province { Id = 1, Name = "آذربایجان شرقی" },
                new Province { Id = 2, Name = "آذربایجان غربی" },
                new Province { Id = 3, Name = "اردبیل" },
                new Province { Id = 4, Name = "اصفهان" },
                new Province { Id = 5, Name = "البرز" },
                new Province { Id = 6, Name = "ایلام" },
                new Province { Id = 7, Name = "بوشهر" },
                new Province { Id = 8, Name = "تهران" },
                new Province { Id = 9, Name = "چهارمحال و بختیاری" },
                new Province { Id = 10, Name = "خراسان جنوبی" },
                new Province { Id = 11, Name = "خراسان رضوی" },
                new Province { Id = 12, Name = "خراسان شمالی" },
                new Province { Id = 13, Name = "خوزستان" },
                new Province { Id = 14, Name = "زنجان" },
                new Province { Id = 15, Name = "سمنان" },
                new Province { Id = 16, Name = "سیستان و بلوچستان" },
                new Province { Id = 17, Name = "فارس" },
                new Province { Id = 18, Name = "قزوین" },
                new Province { Id = 19, Name = "قم" },
                new Province { Id = 20, Name = "کردستان" },
                new Province { Id = 21, Name = "کرمان" },
                new Province { Id = 22, Name = "کرمانشاه" },
                new Province { Id = 23, Name = "کهگیلویه و بویراحمد" },
                new Province { Id = 24, Name = "گلستان" },
                new Province { Id = 25, Name = "گیلان" },
                new Province { Id = 26, Name = "لرستان" },
                new Province { Id = 27, Name = "مازندران" },
                new Province { Id = 28, Name = "مرکزی" },
                new Province { Id = 29, Name = "هرمزگان" },
                new Province { Id = 30, Name = "همدان" },
                new Province { Id = 31, Name = "یزد" });

            #endregion

            #region دیتای اولیه


            //#region ادمین
            ////modelBuilder.Entity<Admin>().HasData
            ////    (
            ////        new Admin
            ////        {
            ////            Id = 1,
            ////            Email = "admin@admin.com",
            ////            Password = "admin",
            ////        }
            ////    );
            //#endregion

            //#region مشتری
            ////modelBuilder.Entity<Customer>().HasData
            ////(
            ////    new Customer
            ////    {
            ////        Id = 1,
            ////        Email = "ali@ali.com",
            ////        Password = "ali", 
            ////    }
            ////);
            //#endregion

            //#region کارشناس
            ////modelBuilder.Entity<Expert>().HasData
            ////(
            ////    new Expert
            ////    {
            ////        Id = 1,
            ////        Email = "hasn@hasan.com",
            ////        Password = "hasan",
            ////    }
            ////);
            //#endregion

            //#region دسته بندی ها
            //modelBuilder.Entity<Category>().HasData
            //    (
            //        new Category
            //        {
            //            Id = 1,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "دکوراسیون ساختمان",
            //        },
            //        new Category
            //        {
            //            Id = 2,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "تاسیسات ساختمان",
            //        }
            //        ,
            //        new Category
            //        {
            //            Id = 3,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "وسیله نقلیه",
            //        },
            //        new Category
            //        {
            //            Id = 4,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "اسبابکشی و باربری",
            //        },
            //        new Category
            //        {
            //            Id = 5,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "لوازم خانگی",
            //        },
            //        new Category
            //        {
            //            Id = 6,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "خدمات اداری",
            //        },
            //        new Category
            //        {
            //            Id = 7,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "نظافت و بهداشت",
            //        },
            //        new Category
            //        {
            //            Id = 8,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "دیجیتال و نرم افزار",
            //        },
            //        new Category
            //        {
            //            Id = 9,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            Photo = new Photo(),
            //            Title = "پزشکی و سلامت",
            //        }
            //    );
            //#endregion

            //#region زیر دسته بندی ها
            //modelBuilder.Entity<SubCategory>().HasData
            //    (

            //        //****************************************************
            //        // 1 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 1,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "بنایی",
            //        },
            //        new SubCategory
            //        {
            //            Id = 2,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "دکوراسیون",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 3,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "نقاشی ساختمان",
            //        },
            //        new SubCategory
            //        {
            //            Id = 4,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "درب و پنجره",
            //        },
            //        new SubCategory
            //        {
            //            Id = 5,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "آهنگری و جوشکاری",
            //        },
            //        new SubCategory
            //        {
            //            Id = 6,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "باغبانی",
            //        },

            //        //****************************************************
            //        // 2 -------------------------------------------------
            //        //****************************************************
            //        new SubCategory
            //        {
            //            Id = 7,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "سرمایش و گرمایش",
            //        },
            //        new SubCategory
            //        {
            //            Id = 8,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "لوله کشی",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 9,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "برقو الکترونیک",
            //        },
            //        new SubCategory
            //        {
            //            Id = 10,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "تلفن و سانترال",
            //        },

            //        //****************************************************
            //        // 3 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 11,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 3,
            //            Photo = new Photo(),
            //            Title = "خودرو",
            //        },

            //        //****************************************************
            //        // 4 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 12,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 4,
            //            Photo = new Photo(),
            //            Title = "اسبابکشی",
            //        },
            //        new SubCategory
            //        {
            //            Id = 13,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 4,
            //            Photo = new Photo(),
            //            Title = "حمل بار",
            //        }
            //        ,

            //        //****************************************************
            //        // 5 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 14,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 5,
            //            Photo = new Photo(),
            //            Title = "لوازم آشپزخانه",
            //        },
            //        new SubCategory
            //        {
            //            Id = 15,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 5,
            //            Photo = new Photo(),
            //            Title = "لوازم شست و شو",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 16,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 5,
            //            Photo = new Photo(),
            //            Title = "لوازم صوتی و تصویری",
            //        },

            //        //****************************************************
            //        // 6 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 17,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 6,
            //            Photo = new Photo(),
            //            Title = "ماشین آلات اداری",
            //        },
            //        new SubCategory
            //        {
            //            Id = 18,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 6,
            //            Photo = new Photo(),
            //            Title = "مبلمان اداری",
            //        }
            //        ,

            //        //****************************************************
            //        // 7 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 19,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 7,
            //            Photo = new Photo(),
            //            Title = "نظافت",
            //        },
            //        new SubCategory
            //        {
            //            Id = 20,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 7,
            //            Photo = new Photo(),
            //            Title = "خشک شویی و اتوشویی",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 21,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 7,
            //            Photo = new Photo(),
            //            Title = "قالی شویی و مبل شویی",
            //        },
            //        new SubCategory
            //        {
            //            Id = 22,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 7,
            //            Photo = new Photo(),
            //            Title = "سمپاشی",
            //        },


            //        //****************************************************
            //        // 8 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 23,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 8,
            //            Photo = new Photo(),
            //            Title = "موبایل و تبلت",
            //        },
            //        new SubCategory
            //        {
            //            Id = 24,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 8,
            //            Photo = new Photo(),
            //            Title = "خدمات کامپیوتری",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 25,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 8,
            //            Photo = new Photo(),
            //            Title = "امنیت و شبکه",
            //        },


            //        //****************************************************
            //        // 9 -------------------------------------------------
            //        //****************************************************

            //        new SubCategory
            //        {
            //            Id = 26,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 9,
            //            Photo = new Photo(),
            //            Title = "معاینه پزشک",
            //        },
            //        new SubCategory
            //        {
            //            Id = 27,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 9,
            //            Photo = new Photo(),
            //            Title = "داروخانه",
            //        }
            //        ,
            //        new SubCategory
            //        {
            //            Id = 28,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            CategoryId = 9,
            //            Photo = new Photo(),
            //            Title = "مشاوره",
            //        }
            //    );
            //#endregion

            //#region خدمات
            //modelBuilder.Entity<Work>().HasData
            //    (

            //        new Work
            //        {
            //            Id = 1,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "پی ریزی",
            //            CorePrice = 500,
            //            Description="انجام انواع امور پی ریزی"
            //        },

            //        new Work
            //        {
            //            Id = 2,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "بلوک گذاری و دیوار چینی",
            //            CorePrice = 1000,
            //            Description = "انجام انواع امور بلوک گذاری و دیوار چینی"
            //        },

            //        new Work
            //        {
            //            Id = 3,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "کف ساختمان",
            //            CorePrice = 600,
            //            Description = "انجام انواع امور مرتبط با کف ساختمان"
            //        },

            //        new Work
            //        {
            //            Id = 4,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "نوسازی",
            //            CorePrice = 6000,
            //            Description = "انجام انواع امور نوسازی ساختمان های قدیمی یا نیازمند تغییر"
            //        },

            //        new Work
            //        {
            //            Id = 5,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 1,
            //            Photo = new Photo(),
            //            Title = "سیمان کاری",
            //            CorePrice = 500,
            //            Description = "انجام انواع امور سیمان کاری"
            //        },

            //        new Work
            //        {
            //            Id = 6,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "دکور آشپزخانه",
            //            CorePrice = 500,
            //            Description = "انجام انواع امور دکور آشپزخانه"
            //        },

            //        new Work
            //        {
            //            Id = 7,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "دکور حال و پذیرایی",
            //            CorePrice = 580,
            //            Description = "انجام انواع امور دکور حال و پذیرایی"
            //        },

            //        new Work
            //        {
            //            Id = 8,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "دکور اتاق خواب",
            //            CorePrice = 400,
            //            Description = "انجام انواع امور دکور اتاق خواب"
            //        },

            //        new Work
            //        {
            //            Id = 9,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "طراحی و دیزاین ساختمان",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور طراحی و دیزاین ساختمان"
            //        },

            //        new Work
            //        {
            //            Id = 10,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 2,
            //            Photo = new Photo(),
            //            Title = "معماری داخلی",
            //            CorePrice = 1500,
            //            Description = "انجام انواع امور معماری داخلی"
            //        },



            //        new Work
            //        {
            //            Id = 11,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 3,
            //            Photo = new Photo(),
            //            Title = "نقاشی داخل ساختمان",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور نقاشی داخل ساختمان"
            //        },

            //        new Work
            //        {
            //            Id = 12,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 3,
            //            Photo = new Photo(),
            //            Title = "نقاشی خارج ساختمان",
            //            CorePrice = 300,
            //            Description = "انجام انواع امور نقاشی خارج ساختمان"
            //        },



            //        new Work
            //        {
            //            Id = 13,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 4,
            //            Photo = new Photo(),
            //            Title = "تعمیرات درب و پنجره",
            //            CorePrice = 200,
            //            Description = "انجام انواع امور تعمیرات درب و پنجره"
            //        },
            //        new Work
            //        {
            //            Id = 14,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 4,
            //            Photo = new Photo(),
            //            Title = "سفارش درب و پنجره",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور سفارش درب و پنجرهن"
            //        },



            //        new Work
            //        {
            //            Id = 15,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 5,
            //            Photo = new Photo(),
            //            Title = "آهنگری و جوشکاری لوازم و غیره",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور آهنگری و جوشکاری لوازم و غیره"
            //        },
            //        new Work
            //        {
            //            Id = 16,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 5,
            //            Photo = new Photo(),
            //            Title = "آهنگری و جوشکاری ساختمانی",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور آهنگری و جوشکاری ساختمانی"
            //        },


            //        new Work
            //        {
            //            Id = 17,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 6,
            //            Photo = new Photo(),
            //            Title = "باغبانی ساختمان ها ومجتمع ها ",
            //            CorePrice = 500,
            //            Description = "انجام انواع امور باغبانی ساختمان ها ومجتمع ها"
            //        },
            //        new Work
            //        {
            //            Id = 18,
            //            CreateAt = DateTime.UtcNow,
            //            UpdateAt = DateTime.UtcNow,
            //            SubCategoryId = 6,
            //            Photo = new Photo(),
            //            Title = "باغبانی فضای شهری و سازمان ها",
            //            CorePrice = 800,
            //            Description = "انجام انواع امور باغبانی فضای شهری و سازمان ها"
            //        }
            //    );
                    
            //#endregion

            //#region کامنت

            //#endregion

            //#region درخواست مشتری

            //#endregion

            //#region درخواست کارشناس

            //#endregion



            //#region رول ها

            //#endregion


            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
