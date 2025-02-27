using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Categorys.Contract.Service
{
    public interface ICategoryService
    {
        public Task<Category> Get(int id, CancellationToken cancellationToken);
        public Task<List<Category>> GetAll(CancellationToken cancellationToken);
        public Task<Category> Add(CategoryDto category, CancellationToken cancellationToken);
        public Task<Category> Update(CategoryDto category, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
