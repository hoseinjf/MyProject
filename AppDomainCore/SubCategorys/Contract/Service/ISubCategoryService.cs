using AppDomainCore.SubCategorys.DTO;
using AppDomainCore.SubCategorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.SubCategorys.Contract.Service
{
    public interface ISubCategoryService
    {
        public Task<SubCategory> Get(int id, CancellationToken cancellationToken);
        public Task<List<SubCategory>> GetAll(CancellationToken cancellationToken);
        public Task<SubCategory> Add(SubCategoryDto subCategory, CancellationToken cancellationToken);
        public Task<SubCategory> Update(SubCategoryDto subCategory, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
