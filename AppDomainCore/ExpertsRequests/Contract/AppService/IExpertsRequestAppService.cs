using AppDomainCore.ExpertsRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.ExpertsRequests.Contract.AppService
{
    public interface IExpertsRequestAppService
    {
        public Task<ExpertsRequest> Get(int id, CancellationToken cancellationToken);
        public Task<List<ExpertsRequest>> GetAll(CancellationToken cancellationToken);
        public Task<ExpertsRequest> Add(ExpertsRequest expertsRequest, CancellationToken cancellationToken);
        public Task<ExpertsRequest> Update(ExpertsRequest expertsRequest, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
