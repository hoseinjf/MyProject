using AppDataRepository.Db;
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
            return request;
        }

        public async Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.ExpertsRequests.ToListAsync(cancellationToken);
        }

        public async Task<ExpertsRequest> Update(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            _db.ExpertsRequests.Update(expertsRequest);
            await _db.SaveChangesAsync(cancellationToken);
            return expertsRequest;
        }
    }
}
