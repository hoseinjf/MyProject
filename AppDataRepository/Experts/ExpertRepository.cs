using AppDataRepository.Db;
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
            return expert;
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Experts.ToListAsync(cancellationToken);
        }

        public async Task<Expert> Update(Expert expert, CancellationToken cancellationToken)
        {
            _db.Experts.Update(expert);
            await _db.SaveChangesAsync(cancellationToken);
            return expert;
        }
    }
}
