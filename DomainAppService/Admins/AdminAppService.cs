using AppDomainCore.Admins.Contract.AppService;
using AppDomainCore.Admins.Contract.Service;
using AppDomainCore.Admins.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Admins
{
    public class AdminAppService : IAdminAppService
    {
        private readonly IAdminService _adminService;
        public AdminAppService(IAdminService adminService)
        {
            _adminService = adminService;
        }


        public async Task<Admin> Add(Admin admin, CancellationToken cancellationToken)
        {
            return await _adminService.Add(admin, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _adminService.Delete(id, cancellationToken);
        }

        public async Task<Admin> Get(int id, CancellationToken cancellationToken)
        {
            return await _adminService.Get(id, cancellationToken);
        }

        public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
        {
            return await _adminService.GetAll(cancellationToken);
        }

        public async Task<Admin> Update(Admin admin, CancellationToken cancellationToken)
        {
            return await _adminService.Update(admin, cancellationToken);
        }
    }
}
