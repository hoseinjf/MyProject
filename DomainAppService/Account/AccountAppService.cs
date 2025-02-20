using AppDomainCore.Account.AppService;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.DTO;
using AppDomainCore.Users.Entity;
using AppDomainCore.Users.Enum;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Account
{
    public class AccountAppService : IAccountAppService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        public AccountAppService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public async Task<IdentityResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        {


            var user = new User();
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;
            //var Role = new IdentityRole();

            //if (registerDto.AccountRole == EnumRole.Expert)
            //{
            //    Role.Name = EnumRole.Expert.ToString();
            //    User.Experts = new Expert();
            //}
            //if (registerDto.AccountRole == EnumRole.Customer)
            //{
            //    Role.Name = EnumRole.Customer.ToString();
            //    User.Customers = new Customer();
            //}

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (result.Succeeded)
            {
                await _signInManager.SignInAsync(user, isPersistent: false);
            }
            return result;

        }

    }
}

