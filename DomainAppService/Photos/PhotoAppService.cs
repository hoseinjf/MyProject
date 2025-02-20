using AppDomainCore.Photos.Contract.AppService;
using AppDomainCore.Photos.Contract.Repository;
using AppDomainCore.Photos.Contract.Service;
using AppDomainCore.Photos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Photos
{
    public class PhotoAppService : IPhotoAppService
    {
        private readonly IPhotoService _repo;
        public PhotoAppService(IPhotoService photo)
        {
            _repo = photo;
        }

        public async Task<Photo> Add(Photo photo, CancellationToken cancellationToken)
        {
            return await _repo.Add(photo, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _repo.Delete(id, cancellationToken);
        }

        public async Task<Photo> Get(int id, CancellationToken cancellationToken)
        {
            return await _repo.Get(id, cancellationToken);
        }

        public async Task<List<Photo>> GetAll(CancellationToken cancellationToken)
        {
            return await _repo.GetAll(cancellationToken);
        }

        public async Task<Photo> Update(Photo photo, CancellationToken cancellationToken)
        {
            return await _repo.Update(photo, cancellationToken);
        }
    }
}
