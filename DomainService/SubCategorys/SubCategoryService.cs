using AppDomainCore.SubCategorys.Contract.Repository;
using AppDomainCore.SubCategorys.Contract.Service;
using AppDomainCore.SubCategorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.SubCategorys
{
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _repository;
        public SubCategoryService(ISubCategoryRepository subCategoryRepository)
        {
            _repository = subCategoryRepository;
        }
        public async Task<SubCategory> Add(SubCategory subCategory, CancellationToken cancellationToken)
        {
            var item = await _repository.Add(subCategory, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _repository.Delete(id, cancellationToken);
        }

        public async Task<SubCategory> Get(int id, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(id, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            var item = await _repository.GetAll( cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<SubCategory> Update(SubCategory subCategory, CancellationToken cancellationToken)
        {
            var item = await _repository.Update(subCategory, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }
    }
}
