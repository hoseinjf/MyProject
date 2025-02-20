using AppDomainCore.ExpertsRequests.Entity;
using AppDomainCore.Photos.Contract.Repository;
using AppDomainCore.Photos.Contract.Service;
using AppDomainCore.Photos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Photos
{
    public class PhotoService : IPhotoService
    {
        private readonly IPhotoRepository _photoRepository;
        public PhotoService(IPhotoRepository photoRepository)
        {
            _photoRepository = photoRepository;
        }
        public async Task<Photo> Add(Photo photo, CancellationToken cancellationToken)
        {
            var item =await _photoRepository.Add(photo, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _photoRepository.Delete(id, cancellationToken);
        }

        public async Task<Photo> Get(int id, CancellationToken cancellationToken)
        {
            var item = await _photoRepository.Get(id, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<List<Photo>> GetAll(CancellationToken cancellationToken)
        {
            var item = await _photoRepository.GetAll( cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }

        public async Task<Photo> Update(Photo photo, CancellationToken cancellationToken)
        {
            var item = await _photoRepository.Update(photo, cancellationToken);
            if (item == null) throw new ArgumentNullException("موردی یافت نشد");
            return item;
        }
    }
}
