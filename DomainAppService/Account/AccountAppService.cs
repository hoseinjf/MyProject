using AppDomainCore.Account.AppService;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Base;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.DTO;
using AppDomainCore.Users.Entity;
using AppDomainCore.Users.Enum;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Account
{
    public class AccountAppService : IAccountAppService
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        private readonly IBaseDataService _bas;
        public AccountAppService(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole<int>> roleManager, IBaseDataService baseDataService)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _roleManager = roleManager;
            _bas = baseDataService;
        }

        public async Task<IdentityResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            var user = new User();
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;
			var Role = "";

			if (registerDto.UserRole == EnumRole.Customer)
            {
                if (await _roleManager.RoleExistsAsync(EnumRole.Customer.ToString()))
                {
					Role = "Customer";
					Customer customer = new Customer()
                    {
                        UserId = user.Id,
                    };
                    user.Customers = customer;
                    //customer.User = user;

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
					Role = "Expert";
					Expert expert = new Expert()
                    {
                        UserId = user.Id,

                    };
                    user.Experts = expert;
                    expert.User = user;
                }
                else
                {
                    return IdentityResult.Failed(new IdentityError { Description = "رول اکسپرت وجود ندارد" });
                }
            }
			var result = await _userManager.CreateAsync(user, registerDto.Password);
			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, Role);

				if (registerDto.UserRole == EnumRole.Customer)
				{
					await _userManager.AddClaimAsync(user, new Claim("CustomerId", user.Customers.Id.ToString()));
				}

				if (registerDto.UserRole == EnumRole.Expert)
				{
					await _userManager.AddClaimAsync(user, new Claim("ExpertId", user.Experts.Id.ToString()));
				}
			}
			else
            {
                return IdentityResult.Failed(new IdentityError { Description = "هیچ رولی وجود ندارد" });
            }

            return result;

        }

        public async Task<IdentityResult> RegisterCustomer(CustomerAddDto registerDto, CancellationToken cancellationToken)
        {
            var user = new User();
            user.Address = registerDto.Address;
            user.FirstName = registerDto.FirstName;
            user.LastName = registerDto.LastName;
            user.Phone = registerDto.Phone;
            user.ProvinceId = registerDto.CityId;
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;
			var Role = "";

            if (registerDto.UserRole == EnumRole.Customer)
            {
                if (await _roleManager.RoleExistsAsync(EnumRole.Customer.ToString()))
                {
					Role = "Customer";

					registerDto.Photo = new AppDomainCore.Photos.Entity.Photo()
                    {
                        Src = await _bas.UploadImage(registerDto.Pic, "customer", cancellationToken),

                    };
                    user.Photo = registerDto.Photo;

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
					Role = "Expert";

					registerDto.Photo = new AppDomainCore.Photos.Entity.Photo()
                    {
                        Src = await _bas.UploadImage(registerDto.Pic, "expert", cancellationToken),

                    };
                    user.Photo = registerDto.Photo;

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
			var result = await _userManager.CreateAsync(user, registerDto.Password);
			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, Role);

				if (registerDto.UserRole == EnumRole.Customer)
				{
					await _userManager.AddClaimAsync(user, new Claim("CustomerId", user.Customers.Id.ToString()));
				}

				if (registerDto.UserRole == EnumRole.Expert)
				{
					await _userManager.AddClaimAsync(user, new Claim("ExpertId", user.Experts.Id.ToString()));
				}
			}
			else
            {
                return IdentityResult.Failed(new IdentityError { Description = "هیچ رولی وجود ندارد" });
            }

            return result;

        }


        public async Task<IdentityResult> RegisterExpert(ExpertAddDto registerDto, CancellationToken cancellationToken)
        {
            var user = new User();
            user.Address = registerDto.Address;
            user.FirstName = registerDto.FirstName;
            user.LastName = registerDto.LastName;
            user.Phone = registerDto.Phone;
            user.ProvinceId = registerDto.CityId;
            user.Email = registerDto.Email;
            user.UserName = registerDto.Email;
			var Role = "";

            if (registerDto.UserRole == EnumRole.Customer)
            {
                if (await _roleManager.RoleExistsAsync(EnumRole.Customer.ToString()))
                {
					Role = "Customer";

					registerDto.Photo = new AppDomainCore.Photos.Entity.Photo()
                    {
                        Src = await _bas.UploadImage(registerDto.Pic, "customer", cancellationToken),

                    };
                    user.Photo = registerDto.Photo;

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
					Role = "Expert";

					registerDto.Photo = new AppDomainCore.Photos.Entity.Photo()
                    {
                        Src = await _bas.UploadImage(registerDto.Pic, "expert", cancellationToken),

                    };
                    user.Photo = registerDto.Photo;

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
			var result = await _userManager.CreateAsync(user, registerDto.Password);
			if (result.Succeeded)
			{
				await _userManager.AddToRoleAsync(user, Role);

				if (registerDto.UserRole == EnumRole.Customer)
				{
					await _userManager.AddClaimAsync(user, new Claim("CustomerId", user.Customers.Id.ToString()));
				}

				if (registerDto.UserRole == EnumRole.Expert)
				{
					await _userManager.AddClaimAsync(user, new Claim("ExpertId", user.Experts.Id.ToString()));
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

