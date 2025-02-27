using AppDataRepository.Db.Context;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Contract.Repository;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Customers
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _db;
        public CustomerRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Customer> Add(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            Customer customer1 = new Customer();
            customer1.User = new User()
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                Address = customer.Address,
                UserName = customer.UserName,
                PasswordHash = customer.Password,
                NormalizedEmail = customer.Email,
                NormalizedUserName = customer.UserName,
                Phone = customer.Phone,
                Photo = customer.Photo,
                ProvinceId = customer.CityId

            };
            //customer1.User.Province.Name = customer.City;
            await _db.Customers.AddAsync(customer1, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return customer1;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (customer == null) { return false; }
            var userId = customer.UserId;
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user.IsDelete == false)
            {
                user.IsDelete = true;
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Include(x => x.User).Where(x => x.User.IsDelete == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (customer == null) { throw new Exception("کاربر یافت نشد"); }
            return customer;
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Customers.Include(x => x.User.Photo).Include(x => x.User.Province).Where(x => x.User.IsDelete == false).ToListAsync(cancellationToken);
        }

        public async Task<Customer> Update(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            var customer1 = await _db.Customers.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == customer.Id, cancellationToken);
            if (customer1 == null) { throw new Exception("کاربر یافت نشد"); }

            customer1.Id = customer.Id;
            customer1.User.Id = customer.UserId;
            customer1.User.FirstName = customer.FirstName;
            customer1.User.LastName = customer.LastName;
            customer1.User.Email = customer.Email;
            customer1.User.Address = customer.Address;
            customer1.User.UserName = customer.UserName;
            //customer1.User.PasswordHash = customer.Password;
            customer1.User.NormalizedEmail = customer.Email;
            customer1.User.NormalizedUserName = customer.UserName;
            customer1.User.Phone = customer.Phone;
            customer1.User.Photo = customer.Photo;
            customer1.User.ProvinceId = customer.CityId;

            await _db.SaveChangesAsync(cancellationToken);
            return customer1;
        }
    }
}
