using AppDomainCore.Experts.Contract.AppService;
using AppDomainCore.Experts.Contract.Service;
using AppDomainCore.Experts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Experts
{
    public class ExpertAppService : IExpertAppService
    {
        private readonly IExpertService _service;
        public ExpertAppService(IExpertService expertService)
        {
            _service = expertService;
        }
        public async Task<Expert> Add(Expert expert, CancellationToken cancellationToken)
        {
            return await _service.Add(expert, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _service.Delete(id, cancellationToken);
        }

        public async Task<Expert> Get(int id, CancellationToken cancellationToken)
        {
            return await _service.Get(id, cancellationToken);
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
            return await _service.GetAll(cancellationToken);
        }

        public async Task<Expert> Update(Expert expert, CancellationToken cancellationToken)
        {
            return await _service.Update(expert,cancellationToken);
        }
    }
}
