using AppDomainCore.Admins.Contract.Repository;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Categorys.Contract.Repository;
using AppDomainCore.Categorys.Contract.Service;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Categorys
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<Category> Add(CategoryDto category, CancellationToken cancellationToken)
        {
            var cat =await _categoryRepository.Add(category, cancellationToken);
            if (cat == null) throw new ArgumentNullException("موردی یافت نشد");
            return cat;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _categoryRepository.Delete(id, cancellationToken);
        }

        public async Task<Category> Get(int id, CancellationToken cancellationToken)
        {
            var cat = await _categoryRepository.Get(id, cancellationToken);
            if (cat == null) throw new ArgumentNullException("موردی یافت نشد");
            return cat;
        }

        public async Task<List<Category>> GetAll(CancellationToken cancellationToken)
        {
            var cat = await _categoryRepository.GetAll( cancellationToken);
            if (cat == null) throw new ArgumentNullException("موردی یافت نشد");
            return cat;
        }

        public async Task<Category> Update(Category category, CancellationToken cancellationToken)
        {
            var cat = await _categoryRepository.Update(category, cancellationToken);
            if (cat == null) throw new ArgumentNullException("موردی یافت نشد");
            return cat;
        }
    }
}
