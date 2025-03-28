﻿using AppDataRepository.Db.Context;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Categorys.Contract.Repository;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;
using AppDomainCore.Photos.Entity;
using AppDomainCore.SiteSetting;

namespace AppDataRepository.Categorys
{
	public class CategoryRepository : ICategoryRepository
	{
		private readonly AppDbContext _db;
		private readonly SiteSettings _siteSettings;

		public CategoryRepository(AppDbContext appDb, SiteSettings siteSettings)
		{
			_db = appDb;
			_siteSettings = siteSettings;
		}

		public async Task<Category> Add(CategoryDto category, CancellationToken cancellationToken)
		{
			try
			{
				Category category1 = new Category()
				{
					Photo = category.Photo,
					Title = category.Title,

				};
				category1.subCategories = category.subCategories;

				await _db.Categories.AddAsync(category1, cancellationToken);
				await _db.SaveChangesAsync(cancellationToken);
				return category1;
			}
			catch (Exception ex)
			{
				return new Category();
			}

		}

		public async Task<bool> Delete(int id, CancellationToken cancellationToken)
		{
			var category = await _db.Categories.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
			if (category == null) { return false; }

			if (category.IsDelete == false)
			{
				category.IsDelete = true;
				await _db.SaveChangesAsync(cancellationToken);
				return true;
			}
			return false;
		}

		public async Task<Category> Get(int id, CancellationToken cancellationToken)
		{
			var category = await _db.Categories.Include(x => x.Photo).Where(x => x.IsDelete == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
			if (category == null) { throw new Exception("کاربر یافت نشد"); }
			return category;
		}

		public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
		{
			var sql = @"SELECT 
                  c.Id, c.Title, c.IsDelete, c.PhotoId AS CategoryPhotoId
                  FROM Categories c
                  WHERE c.IsDelete = 0;";

			using IDbConnection db = new SqlConnection(_siteSettings.ConnectionStrings.SqlConnection);
			var result = await db.QueryAsync<Category>(sql);
			return result.ToList();
			//return await _db.Categories.Include(x => x.Photo).Where(x => x.IsDelete == false).ToListAsync(cancellationToken);
		}

		public async Task<Category> Update(CategoryDto category, CancellationToken cancellationToken)
		{
			//CategoryDto dto = new CategoryDto();
			var category1 = await _db.Categories.FirstOrDefaultAsync(x => x.Id == category.Id, cancellationToken);
			if (category1 == null) { throw new Exception("کامنت یافت نشد"); }

			category1.Id = category.Id;
			category1.subCategories = category.subCategories;
			category1.Photo = category.Photo;
			category1.Title = category.Title;

			await _db.SaveChangesAsync(cancellationToken);
			return category1;
		}


	}
}
