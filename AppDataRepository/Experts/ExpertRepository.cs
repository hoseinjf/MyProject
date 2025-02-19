using AppDataRepository.Db;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Contract.Repository;
using AppDomainCore.Experts.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Experts
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly AppDbContext _db;

        public ExpertRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Expert> Add(Expert expert, CancellationToken cancellationToken)
        {
            await _db.Experts.AddAsync(expert, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return expert;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var expert = await _db.Experts.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (expert == null) { return false; }
            _db.Experts.Remove(expert);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Expert> Get(int id, CancellationToken cancellationToken)
        {
            var expert = await _db.Experts.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            if (expert == null) { throw new Exception("کاربر یافت نشد"); }

            return expert;
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Experts.ToListAsync(cancellationToken);
        }

        public async Task<Expert> Update(Expert model, CancellationToken cancellationToken)
        {
            var expert = await _db.Experts.Include(x => x.Works).FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (expert == null) { throw new Exception("کامنت یافت نشد"); }

            expert.Id = model.Id;
            expert.UserId = model.UserId;
            expert.Biography = model.Biography;
            expert.Score = model.Score;

            await _db.SaveChangesAsync(cancellationToken);
            return expert;
        }
    }
}
