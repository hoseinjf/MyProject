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
                ProvinceId=customer.CityId

            };
            //customer1.User.Province.Name = customer.City;
            await _db.Customers.AddAsync(customer1,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return customer1;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Include(x=>x.User).FirstOrDefaultAsync(x => x.Id == id,cancellationToken);  
            if (customer == null) { return false; }
            var del = customer.User.IsDelete;
            if (del == false) 
            {
                del = true;
                await _db.SaveChangesAsync(cancellationToken);
                return true; 
            }
            return false;
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Where(x=>x.User.IsDelete==false).FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            if (customer == null) { throw new Exception("کاربر یافت نشد"); }
            return customer;
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Customers.Include(x=> x.User).Where(x => x.User.IsDelete == false).ToListAsync(cancellationToken);
        }

        public async Task<Customer> Update(Customer model, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Include(x=>x.User).FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (customer == null) { throw new Exception("کامنت یافت نشد"); }



            await _db.SaveChangesAsync(cancellationToken);
            return customer;
        }
    }
}
