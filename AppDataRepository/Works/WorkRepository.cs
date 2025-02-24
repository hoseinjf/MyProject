using AppDataRepository.Db.Context;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.DTO;
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

        public async Task<Work> Add(WorkDto work, CancellationToken cancellationToken)
        {
            Work work1 = new Work()
            {
                CorePrice = work.CorePrice,
                Description = work.Description,
                Viwe=work.Viwe,
                SubCategoryId=work.SubCategoryId,
                Photo = work.Photo,
                Title = work.Title,
            };

            await _db.Works.AddAsync(work1, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return work1;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var work = await _db.Works.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (work == null) { return false; }

            if (work.IsDelete == false)
            {
                work.IsDelete = true;
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }

        public async Task<Work> Get(int id, CancellationToken cancellationToken)
        {
            var work = await _db.Works.Include(x => x.Photo).Where(x => x.IsDelete == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (work == null) { throw new Exception("کاربر یافت نشد"); }
            return work;
        }

        public async Task<List<Work>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Works.Include(x => x.Photo).Where(x => x.IsDelete == false).ToListAsync(cancellationToken);
        }

        public async Task<Work> Update(Work work, CancellationToken cancellationToken)
        {
            var work1 = await _db.Works.FirstOrDefaultAsync(x => x.Id == work.Id, cancellationToken);
            if (work1 == null) { throw new Exception("کامنت یافت نشد"); }

            work1.CorePrice = work.CorePrice;
            work1.SubCategoryId = work.SubCategoryId;
            work1.Description = work.Description;
            work1.Viwe = work1.Viwe;
            work1.Photo = work.Photo;
            work1.Title = work.Title;

            await _db.SaveChangesAsync(cancellationToken);
            return work1;
        }


    }
}
