using AppDomainCore.Provinces.Contract.AppService;
using AppDomainCore.Provinces.Contract.Service;
using AppDomainCore.Provinces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Provinces
{
    public class ProvinceAppService : IprovinceAppService
    {
        private readonly IProvinceService _provinceService;
        public ProvinceAppService(IProvinceService provinceService)
        {
            _provinceService = provinceService;
        }
        public async Task<Province> Get(int id, CancellationToken cancellationToken)
        { 
            return await _provinceService.Get(id, cancellationToken);
        }

        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            return await _provinceService.GetAll(cancellationToken);
        }
    }
}
