using AppDomainCore.Admins.Contract.Repository;
using AppDomainCore.Admins.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AppDomainCore.Users.Entity;
using System.Threading.Tasks;
using AppDataRepository.Db.Context;

namespace AppDataRepository.Admins
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _db;
        public AdminRepository(AppDbContext appDb)
        {
            _db = appDb;
        }
        public async Task<Admin> Add(Admin admin,CancellationToken cancellationToken)
        {
            await _db.Admins.AddAsync(admin, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return admin;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var admin = await _db.Admins.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (admin == null) { return false; }
            _db.Admins.Remove(admin);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Admin> Get(int id, CancellationToken cancellationToken)
        {
            var admin = await _db.Admins.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if(admin == null) { throw new Exception("کاربر یافت نشد"); }
            return admin;
        }

        public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Admins.ToListAsync(cancellationToken);
        }

        public async Task<Admin> Update(Admin model, CancellationToken cancellationToken)
        {
            var admin = await _db.Admins.Include(x=>x.user).FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (admin == null) { throw new Exception("کاربر یافت نشد"); }
            admin.UserId = model.UserId;
            await _db.SaveChangesAsync(cancellationToken);
            return admin;
        }
    }
}
