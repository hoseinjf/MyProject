using AppDomainCore.Account.AppService;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.DTO;
using AppDomainCore.Users.Entity;
using AppDomainCore.Users.Enum;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
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
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        public AccountAppService(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole<int>> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public async Task<IdentityResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            var user = new User();
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;

            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return result;
            }

            if (registerDto.UserRole == EnumRole.Customer)
            {
                if (await _roleManager.RoleExistsAsync(EnumRole.Customer.ToString()))
                {
                    Customer customer = new Customer()
                    {
                        UserId = user.Id,
                    };
                    user.Customers = customer;
                    customer.User = user;
                    await _userManager.AddToRoleAsync(user, EnumRole.Customer.ToString());

                }
                else
                {
                    return IdentityResult.Failed(new IdentityError { Description = "رول مشتری وجود ندارد" });
                }
            }
            else if (registerDto.UserRole == EnumRole.Expert)
            {
                if (await _roleManager.RoleExistsAsync(EnumRole.Expert.ToString()))
                {
                    Expert expert = new Expert()
                    {
                        UserId = user.Id,

                    };
                    user.Experts = expert;
                    expert.User = user;
                    await _userManager.AddToRoleAsync(user, EnumRole.Expert.ToString());
                }
                else
                {
                    return IdentityResult.Failed(new IdentityError { Description = "رول اکسپرت وجود ندارد" });
                }
            }
            else
            {
                return IdentityResult.Failed(new IdentityError { Description = "هیچ رولی وجود ندارد" });
            }

            return result;

        }
        public async Task<SignInResult> Login(LoginDto loginDto, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(loginDto.Email, loginDto.Password, true, false);

            if (result.Succeeded)
            {
                return result;
            }
            return result;

        }

        public void Logout()
        {
            var result = _signInManager.SignOutAsync();
        }


    }
}

