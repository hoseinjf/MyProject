using AppDomainCore.Experts.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Expert.Controllers
{
	[Authorize(Roles = "Expert")]
	[Area(areaName: "Expert")]
	public class DashboardController : Controller
	{
		private readonly IExpertAppService _expertAppService;

		public DashboardController(IExpertAppService expertAppService)
		{
			_expertAppService = expertAppService;
		}

		public async Task<IActionResult> Index(int Id, CancellationToken cancellationToken)
		{
			var Expert = await _expertAppService.Get(Id, cancellationToken);
			ViewBag.Expert = Expert;
			return View();
		}
	}
}
