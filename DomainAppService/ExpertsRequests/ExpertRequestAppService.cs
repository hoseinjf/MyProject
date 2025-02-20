using AppDomainCore.ExpertsRequests.Contract.AppService;
using AppDomainCore.ExpertsRequests.Contract.Service;
using AppDomainCore.ExpertsRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.ExpertsRequests
{
    public class ExpertRequestAppService : IExpertsRequestAppService
    {
        private readonly IExpertsRequestService _service;
        public ExpertRequestAppService(IExpertsRequestService expertsRequestService)
        {
            _service = expertsRequestService;
        }
        public async Task<ExpertsRequest> Add(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            return await _service.Add(expertsRequest, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _service.Delete(id, cancellationToken);
        }

        public async Task<ExpertsRequest> Get(int id, CancellationToken cancellationToken)
        {
            return await _service.Get(id, cancellationToken);
        }

        public async Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _service.GetAll(cancellationToken);
        }

        public async Task<ExpertsRequest> Update(ExpertsRequest expertsRequest, CancellationToken cancellationToken)
        {
            return await _service.Update(expertsRequest,cancellationToken);
        }
    }
}
