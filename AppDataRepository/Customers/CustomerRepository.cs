using AppDataRepository.Db;
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
            _db.Customers.Remove(customer);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            var customer = await _db.Customers.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return customer;
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Customers.ToListAsync(cancellationToken);
        }

        public async Task<Customer> Update(Customer customer, CancellationToken cancellationToken)
        {
            _db.Customers.Update(customer);
            await _db.SaveChangesAsync(cancellationToken);
            return customer;
        }
    }
}
