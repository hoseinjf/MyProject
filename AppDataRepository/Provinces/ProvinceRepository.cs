using AppDataRepository.Db;
using AppDomainCore.Provinces.Contract.Repository;
using AppDomainCore.Provinces.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Provinces
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly AppDbContext _db;

        public ProvinceRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Province> Add(Province province, CancellationToken cancellationToken)
        {
            await _db.Provinces.AddAsync(province, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return province;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var pr = await _db.Provinces.FirstOrDefaultAsync(x => x.Id == id,cancellationToken);
            _db.Provinces.Remove(pr);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Province> Get(int id, CancellationToken cancellationToken)
        {
            var pr = await _db.Provinces.FirstOrDefaultAsync(x=>x.Id == id, cancellationToken);
            return pr;
        }

        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Provinces.ToListAsync(cancellationToken);
        }

        public async Task<Province> Update(Province province, CancellationToken cancellationToken)
        {
            _db.Provinces.Update(province);
            await _db.SaveChangesAsync(cancellationToken);
            return province;
        }
    }
}
