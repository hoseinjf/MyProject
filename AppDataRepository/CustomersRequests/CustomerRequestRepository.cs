using AppDataRepository.Db;
using AppDomainCore.CustomersRequests.Contract.Repository;
using AppDomainCore.CustomersRequests.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.CustomersRequests
{
    internal class CustomerRequestRepository : ICustomerRequestRepository
    {
        private readonly AppDbContext _db;
        public CustomerRequestRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        public async Task<CustomersRequest> Add(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            await _db.CustomersRequests.AddAsync(customersRequest, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return customersRequest;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var request = await _db.CustomersRequests.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            _db.CustomersRequests.Remove(request);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<CustomersRequest> Get(int id, CancellationToken cancellationToken)
        {
            var request = await _db.CustomersRequests.FirstOrDefaultAsync(x=>x.Id == id, cancellationToken);
            return request;
        }

        public async Task<List<CustomersRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.CustomersRequests.ToListAsync(cancellationToken);
        }

        public async Task<CustomersRequest> Update(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            _db.CustomersRequests.Update(customersRequest);
            await _db.SaveChangesAsync(cancellationToken);
            return customersRequest;
        }
    }
}
