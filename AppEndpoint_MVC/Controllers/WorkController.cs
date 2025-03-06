using AppDomainCore.Works.Contract.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Controllers
{
	public class WorkController : Controller
	{
		private readonly IWorkAppService _workAppService;
        public WorkController(IWorkAppService workApp)
        {
            _workAppService = workApp;
        }
        public async Task <IActionResult> Index(int id,CancellationToken cancellationToken)
		{
			var Services = await _workAppService.GetAllId(id,cancellationToken);
			ViewBag.Services = Services;
			return View();
		}
	}
}
