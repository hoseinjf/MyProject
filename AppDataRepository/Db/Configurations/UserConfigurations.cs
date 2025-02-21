using AppDomainCore.Photos.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using AppDomainCore.Admins.Entity;
using System.Reflection;

namespace MaktabNews.Infrastructure.EfCore.Configurations;
public static class UserConfigurations
{
    public static void SeedUsers(ModelBuilder builder)
    {
        builder.Entity<User>().HasOne(x => x.Photo).WithOne(x => x.User);
        var hasher = new PasswordHasher<User>();

        var users = new List<User>
{
            new User()
            {
            Id = 1,
            Email = "Admin@gmail.com",
            NormalizedEmail = "ADMIN@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111111",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 1,
            Balance = 0,
            PhotoId=1
            },
            new User()
            {
            Id = 2,
            Email = "expert@gmail.com",
            NormalizedEmail = "EXPERT@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 2,
            Balance = 0,
            PhotoId = 2
            },
            new User()
            {
            Id = 3,
            Email = "expert@gmail.com",
            NormalizedEmail = "EXPERT@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 3,
            Balance = 0,
            PhotoId = 3
            },
            new User()
            {
            Id = 4,
            Email = "expert@gmail.com",
            NormalizedEmail = "EXPERT@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 4,
            Balance = 0,
            PhotoId = 4
            },
            new User()
            {
            Id = 5,
            Email = "customer@gmail.com",
            NormalizedEmail = "COSTOMER@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 5,
            Balance = 0,
            PhotoId = 5
            },
            new User()
            {
            Id = 6,
            Email = "customer@gmail.com",
            NormalizedEmail = "COSTOMER@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 6,
            Balance = 0,
            PhotoId = 6
            },
            new User()
            {
            Id = 7,
            Email = "customer@gmail.com",
            NormalizedEmail = "COSTOMER@GMAIL.COM",
            LockoutEnabled = false,
            Phone = "09121111112",
            SecurityStamp = Guid.NewGuid().ToString(),
            ProvinceId = 7,
            Balance = 0,
            PhotoId = 7
            }
            };

        foreach (var user in users)
        {
            var passwordHasher = new PasswordHasher<User>();
            user.PasswordHash = passwordHasher.HashPassword(user, "123456");
            builder.Entity<User>().HasData(user);
        }

        builder.Entity<IdentityRole<int>>().HasData(
        new IdentityRole<int>() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
        new IdentityRole<int>() { Id = 2, Name = "Customer", NormalizedName = "CUSTOMER" },
        new IdentityRole<int>() { Id = 3, Name = "Expert", NormalizedName = "EXPERT" });

        builder.Entity<IdentityUserRole<int>>().HasData(
        new IdentityUserRole<int>() { RoleId = 1, UserId = 1 },

        new IdentityUserRole<int>() { RoleId = 2, UserId = 2 },
        new IdentityUserRole<int>() { RoleId = 2, UserId = 3 },
        new IdentityUserRole<int>() { RoleId = 2, UserId = 4 },

        new IdentityUserRole<int>() { RoleId = 3, UserId = 5 },
        new IdentityUserRole<int>() { RoleId = 3, UserId = 6 },
        new IdentityUserRole<int>() { RoleId = 3, UserId = 7 });
    }
}