using AppDomainCore.Experts.Entity;
using AppDomainCore.ExpertsRequests.Contract.Repository;
using AppDomainCore.ExpertsRequests.Contract.Service;
using AppDomainCore.ExpertsRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.ExpertsRequests
{
    public class ExpertRequestService : IExpertsRequestService
    {
        private readonly IExpertsRequestRepository _repository;
        public ExpertRequestService(IExpertsRequestRepository expertsRequestRepository)
        {
            _repository = expertsRequestRepository;
        }
        public async Task<ExpertsRequest> Add(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            var item =await _repository.Add(expertsRequest, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return _repository.Delete(id, cancellationToken);
        }

        public async Task<ExpertsRequest> Get(int id, CancellationToken cancellationToken)
        {
            var item = await _repository.Get(id, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken)
        {
            var item = await _repository.GetAll( cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<ExpertsRequest> Update(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            var item = await _repository.Update(expertsRequest, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }
    }
}
