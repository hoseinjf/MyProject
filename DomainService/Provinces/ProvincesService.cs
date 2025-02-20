using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.Provinces.Contract.Repository;
using AppDomainCore.Provinces.Contract.Service;
using AppDomainCore.Provinces.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Provinces
{
    public class ProvincesService : IProvinceService
    {
        private readonly IProvinceRepository _repository;
        public ProvincesService(IProvinceRepository provinceRepository)
        {
            _repository = provinceRepository;
        }
        public async Task<Province> Get(int id, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(id, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            var item = await _repository.GetAll( cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }
    }
}
