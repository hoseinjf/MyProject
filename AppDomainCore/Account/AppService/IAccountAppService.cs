using AppDomainCore.Customers.DTO;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Users.DTO;
using AppDomainCore.Users.Entity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Account.AppService
{
    public interface IAccountAppService
    {
        public Task<IdentityResult> Register(RegisterDto user, CancellationToken cancellationToken);
        public Task<IdentityResult> RegisterCustomer(CustomerAddDto user, CancellationToken cancellationToken);
        public Task<IdentityResult> RegisterExpert(ExpertAddDto user, CancellationToken cancellationToken);
        public  Task<SignInResult> Login(LoginDto loginDto, CancellationToken cancellationToken);
        public void Logout();
    }
}
