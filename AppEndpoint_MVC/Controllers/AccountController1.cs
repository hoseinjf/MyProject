using AppDomainCore.Account.AppService;
using AppDomainCore.Users.DTO;
using DomainAppService.Account;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Controllers
{
    public class AccountController1 : Controller
    {
        private readonly IAccountAppService _accountAppService;
        public AccountController1(IAccountAppService accountAppService)
        {
            _accountAppService = accountAppService;
        }
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto registerDto, CancellationToken cancellationToken)
        {
            if (ModelState.IsValid)
            {
                var res = await _accountAppService.Register(registerDto, cancellationToken);
                if (res.Succeeded) 
                {
                    RedirectToAction("Index","Home");
                }
            }
            return View(registerDto);
        }

    }
}
