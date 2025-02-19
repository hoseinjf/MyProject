using AppDomainCore.Photos.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Photos.Contract.AppService
{
    public interface IPhotoAppService
    {
        public Task<Photo> Get(int id, CancellationToken cancellationToken);
        public Task<List<Photo>> GetAll(CancellationToken cancellationToken);
        public Task<Photo> Add(Photo photo, CancellationToken cancellationToken);
        public Task<Photo> Update(Photo photo, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
