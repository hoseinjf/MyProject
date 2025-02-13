using AppDomainCore.Admins.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Admins.Contract.Service
{
    public interface IAdminService
    {
        public Task<Admin> Get(int id, CancellationToken cancellationToken);
        public Task<List<Admin>> GetAll(CancellationToken cancellationToken);
        public Task<Admin> Add(Admin admin, CancellationToken cancellationToken);
        public Task<Admin> Update(Admin admin, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
