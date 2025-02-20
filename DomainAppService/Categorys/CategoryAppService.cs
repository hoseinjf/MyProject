using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.Categorys.Contract.Service;
using AppDomainCore.Categorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Categorys
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryService _categoryService;
        public CategoryAppService(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<Category> Add(Category category, CancellationToken cancellationToken)
        {
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
            return await _categoryService.GetAll(cancellationToken);
        }

        public async Task<Category> Update(Category category, CancellationToken cancellationToken)
        {
            return await _categoryService.Update(category, cancellationToken);
        }
    }
}
