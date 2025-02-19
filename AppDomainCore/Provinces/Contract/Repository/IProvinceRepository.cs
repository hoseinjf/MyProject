using AppDomainCore.Provinces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Provinces.Contract.Repository
{
    public interface IProvinceRepository
    {
        public Task<Province> Get(int id, CancellationToken cancellationToken);
        public Task<List<Province>> GetAll(CancellationToken cancellationToken);

    }
}
