using AppDataRepository.Db;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Works
{
    public class WorkRepository : IWorkRepository
    {
        private readonly AppDbContext _db;

        public WorkRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Work> Add(Work work, CancellationToken cancellationToken)
        {
            await _db.Works.AddAsync(work,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return work;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var work = await _db.Works.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (work == null) { return false; }
            _db.Works.Remove(work);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Work> Get(int id, CancellationToken cancellationToken)
        {
            var work = await _db.Works.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return work;
        }

        public async Task<List<Work>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Works.ToListAsync(cancellationToken);
        }

        public async Task<Work> Update(Work work, CancellationToken cancellationToken)
        {
            _db.Works.Update(work);
            await _db.SaveChangesAsync(cancellationToken);
            return work;
        }
    }
}
