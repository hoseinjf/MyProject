using AppDataRepository.Db.Context;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.SubCategorys.Contract.Repository;
using AppDomainCore.SubCategorys.DTO;
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

        public async Task<SubCategory> Add(SubCategoryDto category, CancellationToken cancellationToken)
        {
            SubCategory category1 = new SubCategory()
            {
                Photo = category.Photo,
                Title = category.Title,
                CategoryId = category.CategoryId,

            };
            category1.works = category.works;

            await _db.SubCategories.AddAsync(category1, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return category1;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var category = await _db.SubCategories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (category == null) { return false; }

            if (category.IsDelete == false)
            {
                category.IsDelete = true;
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }

        public async Task<SubCategory> Get(int id, CancellationToken cancellationToken)
        {
            var category = await _db.SubCategories.Include(x => x.Photo).Where(x => x.IsDelete == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (category == null) { throw new Exception("کاربر یافت نشد"); }
            return category;
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.SubCategories.Include(x => x.Photo).Where(x => x.IsDelete == false).ToListAsync(cancellationToken);
        }

        public async Task<SubCategory> Update(SubCategoryDto category, CancellationToken cancellationToken)
        {
            //CategoryDto dto = new CategoryDto();
            var category1 = await _db.SubCategories.FirstOrDefaultAsync(x => x.Id == category.Id, cancellationToken);
            if (category1 == null) { throw new Exception("کامنت یافت نشد"); }

            category1.Id = category.Id;
            category1.CategoryId = category.CategoryId;
            category1.works = category.works;
            category1.Photo = category.Photo;
            category1.Title = category.Title;

            await _db.SaveChangesAsync(cancellationToken);
            return category1;
        }




    }
}
