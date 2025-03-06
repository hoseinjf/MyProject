using AppDomainCore.Base;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Works.Contract.AppService;
using AppDomainCore.Works.Contract.Service;
using AppDomainCore.Works.DTO;
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
        private readonly IBaseDataService _bas;

        public WorkAppService(IWorkService workService, IBaseDataService baseDataService)
        {
            _workService = workService;
            _bas = baseDataService;
        }
        public async Task<Work> Add(WorkDto work, CancellationToken cancellationToken)
        {
            work.Photo = new AppDomainCore.Photos.Entity.Photo()
            {
                Src = await _bas.UploadImage(work.Pic, "work", cancellationToken),
            };
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

		public async Task<List<Work>> GetAllId(int id, CancellationToken cancellationToken)
        {
			return await _workService.GetAllId(id,cancellationToken);

		}


		public async Task<Work> Update(WorkDto work, CancellationToken cancellationToken)
        {
            if (work.Pic != null)
            {
                work.Photo = new AppDomainCore.Photos.Entity.Photo()
                {
                    Src = await _bas.UploadImage(work.Pic, "work", cancellationToken),
                };
            }
            return await _workService.Update(work, cancellationToken);
        }
    }
}
