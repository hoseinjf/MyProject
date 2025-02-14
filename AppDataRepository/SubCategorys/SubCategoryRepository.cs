using AppDataRepository.Db;
using AppDomainCore.SubCategorys.Contract.Repository;
using AppDomainCore.SubCategorys.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.SubCategorys
{
    public class SubCategoryRepository : ISubCategoryRepository
    {
        private readonly AppDbContext _db;

        public SubCategoryRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<SubCategory> Add(SubCategory subCategory, CancellationToken cancellationToken)
        {
            await _db.SubCategories.AddAsync(subCategory,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return subCategory;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var sub = await _db.SubCategories.FirstOrDefaultAsync(c => c.Id == id,cancellationToken);
            if (sub == null) { return false; }
            _db.SubCategories.Remove(sub);
            return true;
        }

        public async Task<SubCategory> Get(int id, CancellationToken cancellationToken)
        {
            var sub = await _db.SubCategories.FirstOrDefaultAsync(x=>x.Id == id,cancellationToken);
            return sub;
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.SubCategories.ToListAsync(cancellationToken);
        }

        public async Task<SubCategory> Update(SubCategory subCategory, CancellationToken cancellationToken)
        {
            _db.SubCategories.Update(subCategory);
            await _db.SaveChangesAsync(cancellationToken);
            return subCategory;
        }
    }
}
