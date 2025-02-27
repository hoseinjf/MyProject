using AppDomainCore.Works.DTO;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Works.Contract.AppService
{
    public interface IWorkAppService
    {
        public Task<Work> Get(int id, CancellationToken cancellationToken);
        public Task<List<Work>> GetAll(CancellationToken cancellationToken);
        public Task<Work> Add(WorkDto work, CancellationToken cancellationToken);
        public Task<Work> Update(WorkDto work, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
