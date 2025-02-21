using AppDomainCore.Account.AppService;
using AppDomainCore.Users.DTO;
using DomainAppService.Account;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountAppService _accountAppService;
        public AccountController(IAccountAppService accountAppService)
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
                    return RedirectToAction("Index","Home");
                }
            }
            return View(registerDto);
        }

        public IActionResult Login() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string Email, string password, CancellationToken cancellationToken)
        {
            var result = _accountAppService.Login(Email, password, cancellationToken);
        }

    }
}
