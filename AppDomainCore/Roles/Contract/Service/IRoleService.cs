using AppDomainCore.Roles.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Roles.Contract.Service
{
    public interface IRoleService
    {
        public Task<Role> Get(int id, CancellationToken cancellationToken);
        public Task<List<Role>> GetAll(CancellationToken cancellationToken);
        public Task<Role> Add(Role role, CancellationToken cancellationToken);
        public Task<Role> Update(Role role, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
