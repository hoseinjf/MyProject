using AppDataRepository.Db.Context;
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


        public async Task<Province> Get(int id, CancellationToken cancellationToken)
        {
            var pr = await _db.Provinces.FirstOrDefaultAsync(x=>x.Id == id, cancellationToken);
            return pr;
        }

        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Provinces.ToListAsync(cancellationToken);
        }

    }
}
