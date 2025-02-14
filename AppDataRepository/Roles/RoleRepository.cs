using AppDataRepository.Db;
using AppDomainCore.Roles.Contract.Repository;
using AppDomainCore.Roles.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Roles
{
    public class RoleRepository : IRoleRepository
    {
        private readonly AppDbContext _db;

        public RoleRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Role> Add(Role role, CancellationToken cancellationToken)
        {
            await _db.Roles.AddAsync(role,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return role;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var role = await _db.Roles.FirstOrDefaultAsync(x=>x.Id==id, cancellationToken);
            if (role == null) { return false; }
            _db.Roles.Remove(role);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Role> Get(int id, CancellationToken cancellationToken)
        {
            var role = await _db.Roles.FirstOrDefaultAsync(x=>x.Id==id,cancellationToken);
            return role;
        }

        public async Task<List<Role>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Roles.ToListAsync(cancellationToken);
        }

        public async Task<Role> Update(Role role, CancellationToken cancellationToken)
        {
            _db.Roles.Update(role);
            await _db.SaveChangesAsync(cancellationToken);
            return role;
        }
    }
}
