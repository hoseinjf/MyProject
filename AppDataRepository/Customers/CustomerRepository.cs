using AppDataRepository.Db;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Contract.Repository;
using AppDomainCore.Customers.Entity;
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
        public async Task<Customer> Add(Customer customer, CancellationToken cancellationToken)
        {
            await _db.Customers.AddAsync(customer,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return customer;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);  
            if (customer == null) { return false; }
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            if (customer == null) { throw new Exception("کاربر یافت نشد"); }
            return customer;
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Customers.ToListAsync(cancellationToken);
        }

        public async Task<Customer> Update(Customer model, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.Include(x=>x.User).FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (customer == null) { throw new Exception("کامنت یافت نشد"); }

            customer.Id = model.Id;
            customer.UserId = model.UserId;

            await _db.SaveChangesAsync(cancellationToken);
            return customer;
        }
    }
}
