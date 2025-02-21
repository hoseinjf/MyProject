using AppDomainCore.Account.AppService;
using AppDomainCore.Admins.Entity;
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
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountAppService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        //public async Task<IdentityResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        //{


        //    var user = new user();
        //    user.Email = registerDto.Email;
        //    user.userName = registerDto.Email;
        //    //var Role = new IdentityRole();

        //    //if (registerDto.AccountRole == EnumRole.Expert)
        //    //{
        //    //    Role.Name = EnumRole.Expert.ToString();
        //    //    user.Experts = new Expert();
        //    //}
        //    //if (registerDto.AccountRole == EnumRole.Customer)
        //    //{
        //    //    Role.Name = EnumRole.Customer.ToString();
        //    //    user.Customers = new Customer();
        //    //}

        //    var result = await _userManager.CreateAsync(user, registerDto.Password);

        //    if (result.Succeeded)
        //    {
        //        await _signInManager.SignInAsync(user, isPersistent: false);
        //    }
        //    return result;

        //}



        public async Task<IdentityResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            var user = new User();
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;
            
            var RoleCu = "Customer";
            var RoleEx = "Expert";
            var result = await _userManager.CreateAsync(user, registerDto.Password);
            if (!result.Succeeded)
            {
                return result;
            }

            if (registerDto.UserRole==EnumRole.Customer)
            {
                if (await _roleManager.RoleExistsAsync("Customer"))
                {
                    await _userManager.AddToRoleAsync(user, "Customer");
                }
                else
                {
                    return IdentityResult.Failed(new IdentityError { Description = "رول مشتری وجود ندارد" });
                }
            }
            else if (registerDto.UserRole == EnumRole.Expert)
            {
                if (await _roleManager.RoleExistsAsync("Expert"))
                {
                    await _userManager.AddToRoleAsync(user, "Expert");
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
        public async Task<SignInResult> Login(string Email, string password, CancellationToken cancellationToken)
        {
            var result = await _signInManager.PasswordSignInAsync(Email, password, true, false);
            return result;
        }



    }
}

