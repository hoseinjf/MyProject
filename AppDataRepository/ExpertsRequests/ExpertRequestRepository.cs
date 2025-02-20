using AppDataRepository.Db.Context;
using AppDomainCore.Customers.Entity;
using AppDomainCore.ExpertsRequests.Contract.Repository;
using AppDomainCore.ExpertsRequests.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.ExpertsRequests
{
    public class ExpertRequestRepository : IExpertsRequestRepository
    {
        private readonly AppDbContext _db;

        public ExpertRequestRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<ExpertsRequest> Add(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            await _db.ExpertsRequests.AddAsync(expertsRequest, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return expertsRequest;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var request = await _db.ExpertsRequests.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (request == null) { return false; }
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<ExpertsRequest> Get(int id, CancellationToken cancellationToken)
        {
            var request = await _db.ExpertsRequests.FirstOrDefaultAsync(x=>x.Id == id, cancellationToken);
            if (request == null) { throw new Exception("درخواستی یافت نشد"); }

            return request;
        }

        public async Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.ExpertsRequests.ToListAsync(cancellationToken);
        }

        public async Task<ExpertsRequest> Update(ExpertsRequest model, CancellationToken cancellationToken)
        {
            var expertsRequest = await _db.ExpertsRequests.FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (expertsRequest == null) { throw new Exception("درخواستی یافت نشد"); }


            expertsRequest.DateWork = model.DateWork;
            expertsRequest.Price = model.Price;
            expertsRequest.Description = model.Description;

            await _db.SaveChangesAsync(cancellationToken);
            return expertsRequest;
        }
    }
}
