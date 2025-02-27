using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.Contract.Service;
using AppDomainCore.Works.DTO;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Works
{
    public class WorkService : IWorkService
    {
        private readonly IWorkRepository _workRepository;
        public WorkService(IWorkRepository workRepository)
        {
            _workRepository = workRepository;
        }
        public async Task<Work> Add(WorkDto work, CancellationToken cancellationToken)
        {
            var item =await _workRepository.Add(work, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return _workRepository.Delete(id, cancellationToken);
        }

        public async Task<Work> Get(int id, CancellationToken cancellationToken)
        {
            var item =await _workRepository.Get(id, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<List<Work>> GetAll(CancellationToken cancellationToken)
        {
            var item =await _workRepository.GetAll( cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<Work> Update(WorkDto work, CancellationToken cancellationToken)
        {
            var item =await _workRepository.Update(work, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }
    }
}
