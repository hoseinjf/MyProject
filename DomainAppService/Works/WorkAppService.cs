using AppDomainCore.Works.Contract.AppService;
using AppDomainCore.Works.Contract.Service;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Works
{
    public class WorkAppService : IWorkAppService
    {
        private readonly IWorkService _workService;
        public WorkAppService(IWorkService workService)
        {
            _workService = workService;
        }
        public async Task<Work> Add(Work work, CancellationToken cancellationToken)
        {
            return await _workService.Add(work, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _workService.Delete(id, cancellationToken);
        }

        public async Task<Work> Get(int id, CancellationToken cancellationToken)
        {
            return await _workService.Get(id, cancellationToken);
        }

        public async Task<List<Work>> GetAll(CancellationToken cancellationToken)
        {
            return await _workService.GetAll(cancellationToken);
        }

        public async Task<Work> Update(Work work, CancellationToken cancellationToken)
        {
            return await _workService.Update(work, cancellationToken);
        }
    }
}
