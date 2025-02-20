using AppDomainCore.Admins.Contract.AppService;
using AppDomainCore.Admins.Contract.Repository;
using AppDomainCore.Admins.Contract.Service;
using AppDomainCore.Admins.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Admins
{
    public class AdminService : IAdminService
    {
        private readonly IAdminRepository _adminRepository;

        public AdminService(IAdminRepository adminRepository)
        {
            _adminRepository = adminRepository;
        }
        public async Task<Admin> Add(Admin admin, CancellationToken cancellationToken)
        {
            var user = await _adminRepository.Add(admin, cancellationToken);
            if (user == null) throw new ArgumentNullException("موردی یافت نشد");
            return user;

        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _adminRepository.Delete(id, cancellationToken);
        }

        public async Task<Admin> Get(int id, CancellationToken cancellationToken)
        {
            var user = await _adminRepository.Get(id, cancellationToken);
            if (user == null) throw new ArgumentNullException("موردی یافت نشد");
            return user;

        }

        public async Task<List<Admin>> GetAll(CancellationToken cancellationToken)
        {
            var user = await _adminRepository.GetAll(cancellationToken);
            if (user == null) throw new ArgumentNullException("موردی یافت نشد");
            return user;

        }

        public async Task<Admin> Update(Admin admin, CancellationToken cancellationToken)
        {
            var user = await _adminRepository.Update(admin, cancellationToken);
            if (user == null) throw new ArgumentNullException("موردی یافت نشد");
            return user;
        }
    }
}
