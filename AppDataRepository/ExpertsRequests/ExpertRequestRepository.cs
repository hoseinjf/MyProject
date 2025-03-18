using AppDataRepository.Db.Context;
using AppDomainCore.Customers.Entity;
using AppDomainCore.ExpertsRequests.Contract.Repository;
using AppDomainCore.ExpertsRequests.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.ExpertsRequests.DTO;

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
            try
            {
                await _db.ExpertsRequests.AddAsync(expertsRequest, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return expertsRequest;
            }
            catch (Exception ex) { return new ExpertsRequest(); }
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var request = await _db.ExpertsRequests.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (request == null) { return false; }
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<ExpertsRequest> Get(int id, CancellationToken cancellationToken)
        {
            var request = await _db.ExpertsRequests.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (request == null) { throw new Exception("درخواستی یافت نشد"); }

            return request;
        }

        public async Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.ExpertsRequests.ToListAsync(cancellationToken);
        }

        public async Task<List<ExpertsRequestDto>> GetAllExpert(int ExpertId, CancellationToken cancellationToken)
        {
            var result = await _db.ExpertsRequests.AsNoTracking().Where(x => x.IsDelete == false && x.ExpertId == ExpertId).Select(x => new ExpertsRequestDto
            {
                Id = x.Id,
                Description = x.Description,
                DateWork = x.DateWork,
                Status = x.CustomersRequest.Status,
                Customer = x.CustomersRequest.Customer,
                City = x.Expert.User.Province,
                Expert = x.Expert,
                Work = x.CustomersRequest.Work,
                CustomersRequest = x.CustomersRequest,
                CreateAt = x.CreateAt,
                Price = x.Price,
                CustomersRequestId = x.CustomersRequestId
            }
            ).ToListAsync(cancellationToken);
            return result;
        }
        public async Task<List<ExpertsRequest>> GetAllCustomerRequest(int id, CancellationToken cancellationToken)
        {
            var x =  await _db.ExpertsRequests
                .Where(x => x.CustomersRequest.Customer.Id == id && x.IsDelete == false)
                .ToListAsync(cancellationToken);
            if (x == null) return new List<ExpertsRequest>();
            return x;
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
