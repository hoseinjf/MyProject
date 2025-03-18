using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Experts.Contract.Repository;
using AppDomainCore.Experts.Contract.Service;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Experts
{
    public class ExpertService : IExpertService
    {
        private readonly IExpertRepository _expertRep;
        public ExpertService(IExpertRepository expertRepository)
        {
            _expertRep = expertRepository;
        }
        public async Task<Expert> Add(ExpertAddDto expert, CancellationToken cancellationToken)
        {
            var com =await _expertRep.Add(expert, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _expertRep.Delete(id, cancellationToken);
        }

        public async Task<Expert> Get(int id, CancellationToken cancellationToken)
        {
            var com = await _expertRep.Get(id, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
            var com = await _expertRep.GetAll(cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<Expert> Update(ExpertAddDto expert, CancellationToken cancellationToken)
        {
            var com = await _expertRep.Update(expert, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<ExpertUpdateProfileDto> GetUpdate(int id, CancellationToken cancellationToken)
        {
            var com = await _expertRep.GetUpdate(id, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<Expert> UpdateProfile(ExpertUpdateProfileDto expert, CancellationToken cancellationToken)
        {
            var com = await _expertRep.UpdateProfile(expert, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

    }
}
