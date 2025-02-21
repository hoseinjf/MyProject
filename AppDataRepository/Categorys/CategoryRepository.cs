﻿using AppDataRepository.Db.Context;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Categorys.Contract.Repository;
using AppDomainCore.Categorys.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Categorys
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _db;
        public CategoryRepository(AppDbContext appDb)
        {
            _db = appDb;
        }
        public async Task<Category> Add(Category category, CancellationToken cancellationToken)
        {
            await _db.Categories.AddAsync(category,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return category;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);
            if (category == null) { return false; }
            _db.Categories.Remove(category);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Category> Get(int id, CancellationToken cancellationToken)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);
            if (category == null) { throw new Exception("دسته بندی یافت نشد"); }
            return category;
        }

        public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Categories.ToListAsync();
        }

        public async Task<Category> Update(Category model, CancellationToken cancellationToken)
        {
            var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (category == null) { throw new Exception("دسته بندی یافت نشد"); }


            category.Title = model.Title;

            await _db.SaveChangesAsync(cancellationToken);
            return category;
        }
    }
}
