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
using AppDataRepository.Db.Configurations;
using MaktabNews.Infrastructure.EfCore.Configurations;

namespace AppDataRepository.Db.Context
{
    public class AppDbContext : IdentityDbContext<User, IdentityRole<int>, int>
    {
        public AppDbContext(DbContextOptions<AppDbContext> dbContext) : base(dbContext)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomersRequest> CustomersRequests { get; set; }
        public DbSet<Expert> Experts { get; set; }
        public DbSet<ExpertsRequest> ExpertsRequests { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<Work> Works { get; set; }
        public DbSet<Photo> Photo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfigurations());
            modelBuilder.ApplyConfiguration(new CategoryConfigurations());
            modelBuilder.ApplyConfiguration(new CommentConfigurations());
            modelBuilder.ApplyConfiguration(new CustomerConfigurations());
            modelBuilder.ApplyConfiguration(new CustomersRequestsConfigurations());
            modelBuilder.ApplyConfiguration(new ExpertConfigurations());
            modelBuilder.ApplyConfiguration(new ExpertsRequestsConfigurations());
            modelBuilder.ApplyConfiguration(new ProvincesConfigurations());
            modelBuilder.ApplyConfiguration(new SubCategorysConfigurations());
            modelBuilder.ApplyConfiguration(new WorksConfigurations());
            modelBuilder.ApplyConfiguration(new PhotoConfigurations());
            UserConfigurations.SeedUsers(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}
