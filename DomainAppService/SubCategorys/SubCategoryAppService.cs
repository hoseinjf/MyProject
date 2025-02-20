using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.SubCategorys.Contract.Service;
using AppDomainCore.SubCategorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.SubCategorys
{
    internal class SubCategoryAppService : ISubCategoryAppService
    {
        private readonly ISubCategoryService _subCategoryService;
        public SubCategoryAppService(ISubCategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }
        public async Task<SubCategory> Add(SubCategory subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Add(subCategory, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Delete(id, cancellationToken);
        }

        public async Task<SubCategory> Get(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Get(id, cancellationToken);
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _subCategoryService.GetAll(cancellationToken);
        }

        public async Task<SubCategory> Update(SubCategory subCategory, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Update(subCategory, cancellationToken);
        }
    }
}
