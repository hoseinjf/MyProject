using AppDomainCore.Users.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Users.Contract.Service
{
    public interface IUserService
    {
        public Task<User> Get(int id, CancellationToken cancellationToken);
        public Task<List<User>> GetAll(CancellationToken cancellationToken);
        public Task<User> Add(User user, CancellationToken cancellationToken);
        public Task<User> Update(User user, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
