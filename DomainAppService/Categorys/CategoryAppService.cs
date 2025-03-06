using AppDomainCore.Base;
using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.Categorys.Contract.Service;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Experts.Entity;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Categorys
{
	public class CategoryAppService : ICategoryAppService
	{
		private readonly ICategoryService _categoryService;
		private readonly IBaseDataService _bas;
		private readonly IMemoryCache _memoryCache;

		public CategoryAppService(ICategoryService categoryService, IBaseDataService baseData, IMemoryCache memoryCache)
		{
			_categoryService = categoryService;
			_bas = baseData;
			_memoryCache = memoryCache;
		}
		public async Task<Category> Add(CategoryDto category, CancellationToken cancellationToken)
		{
			category.Photo = new AppDomainCore.Photos.Entity.Photo()
			{
				Src = await _bas.UploadImage(category.Pic, "category", cancellationToken),
			};
			return await _categoryService.Add(category, cancellationToken);
		}

		public async Task<bool> Delete(int id, CancellationToken cancellationToken)
		{
			return await _categoryService.Delete(id, cancellationToken);
		}

		public async Task<Category> Get(int id, CancellationToken cancellationToken)
		{
			return await _categoryService.Get(id, cancellationToken);
		}

		public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
		{
			List<Category>? x;
			if(_memoryCache.Get("CategoryList") != null)
			{
				x = _memoryCache.Get<List<Category>?>("CategoryList");
			}
			else
			{
				x = await _categoryService.GetAll(cancellationToken);
				_memoryCache.Set("CategoryList",x,TimeSpan.FromSeconds(10));
			}
			return x;

		}

		public async Task<Category> Update(CategoryDto category, CancellationToken cancellationToken)
		{
			if (category.Pic != null)
			{

				category.Photo = new AppDomainCore.Photos.Entity.Photo()
				{
					Src = await _bas.UploadImage(category.Pic, "category", cancellationToken),
				};
			}
			return await _categoryService.Update(category, cancellationToken);
		}
	}
}
