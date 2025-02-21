using AppDataRepository.Db.Context;
using AppDomainCore.Photos.Contract.Repository;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Works.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Photos
{
    public class PhotoRepository : IPhotoRepository
    {
        private readonly AppDbContext _db;
        public PhotoRepository(AppDbContext appDb)
        {
            _db = appDb;
        }
        public async Task<Photo> Add(Photo photo, CancellationToken cancellationToken)
        {
            await _db.AddAsync(photo,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return photo;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var photo= await _db.Photo.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            if (photo == null) { return false; }
            _db.Photo.Remove(photo);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Photo> Get(int id, CancellationToken cancellationToken)
        {
            var photo =await _db.Photo.FirstOrDefaultAsync(_ => _.Id == id,cancellationToken);
            if (photo == null) { throw new Exception("موردی یافت نشد"); }
            return photo;
        }

        public async Task<List<Photo>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Photo.ToListAsync(cancellationToken);

        }

        public async Task<Photo> Update(Photo model, CancellationToken cancellationToken)
        {
            var photo =await _db.Photo.FirstOrDefaultAsync(x=>x.Id == model.Id,cancellationToken);
            if (photo == null) { throw new Exception("موردی یافت نشد"); }


            photo.Src=model.Src;

            await _db.SaveChangesAsync(cancellationToken);
            return photo;
        }
    }
}
