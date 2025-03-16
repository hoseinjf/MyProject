using AppDataRepository.Db.Context;
using AppDomainCore.Provinces.Contract.Repository;
using AppDomainCore.Provinces.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.SiteSetting;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Data;


namespace AppDataRepository.Provinces
{
    public class ProvinceRepository : IProvinceRepository
    {
        private readonly AppDbContext _db;
        private readonly SiteSettings _siteSettings;

        public ProvinceRepository(AppDbContext appDbContext, SiteSettings siteSettings)
        {
	        _db = appDbContext;
	        _siteSettings = siteSettings;
        }


        public async Task<Province> Get(int id, CancellationToken cancellationToken)
        {
            var pr = await _db.Provinces.FirstOrDefaultAsync(x=>x.Id == id, cancellationToken);
            if (pr == null) { throw new Exception("موردی یافت نشد"); }
            return pr;
        }

        public async Task<List<Province>> GetAll(CancellationToken cancellationToken)
        {
	        using IDbConnection db = new SqlConnection(_siteSettings.ConnectionStrings.SqlConnection);
	        var query = "SELECT * FROM Provinces";
	        var Provinces = await db.QueryAsync<Province>(query);
	        return Provinces.ToList();
		}

    }
}
