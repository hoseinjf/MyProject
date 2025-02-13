using AppDataRepository.Db;
using AppDomainCore.Users.Contract.Repository;
using AppDomainCore.Users.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Users
{
    public class UserRepository : IUserRepository
    {
        private readonly AppDbContext _db;

        public UserRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<User> Add(User user, CancellationToken cancellationToken)
        {
            await _db.Users.AddAsync(user,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return user;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            _db.Users.Remove(user);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<User> Get(int id, CancellationToken cancellationToken)
        {
            var user = await _db.Users.FirstOrDefaultAsync( x => x.Id == id, cancellationToken);
            return user;
        }

        public async Task<List<User>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Users.ToListAsync(cancellationToken);
        }

        public async Task<User> Update(User user, CancellationToken cancellationToken)
        {
            _db.Users.Update(user);
            await _db.SaveChangesAsync(cancellationToken);
            return user;
        }
    }
}
