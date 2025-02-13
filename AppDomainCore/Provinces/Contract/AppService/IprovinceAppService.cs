using AppDomainCore.Provinces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Provinces.Contract.AppService
{
    public interface IprovinceAppService
    {
        public Task<Province> Get(int id, CancellationToken cancellationToken);
        public Task<List<Province>> GetAll(CancellationToken cancellationToken);
        public Task<Province> Add(Province province, CancellationToken cancellationToken);
        public Task<Province> Update(Province province, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
