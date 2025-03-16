using AppDomainCore.Account.AppService;
using AppDomainCore.Users.DTO;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoin_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegisterController : ControllerBase
	{
		private readonly IAccountAppService _accountAppService;

		public RegisterController(IAccountAppService accountAppService)
		{
			_accountAppService = accountAppService;
		}


		[HttpPost("UserRegister")]
		public async Task<IActionResult> Register([FromBody] RegisterDto registerDto, CancellationToken cancellationToken)
		{
			if (registerDto == null)
			{
				return BadRequest(new { message = "مقدار ورودی خالی است" });
			}
			var res = await _accountAppService.Register(registerDto, cancellationToken);
			if (res.Succeeded)
			{
				return Ok(new { message = "کاربر اضافه شد", });
			}
			else
			{
				return BadRequest(new { message = "مشکلی به وجود آمده" });
			}
		}
	}
}
