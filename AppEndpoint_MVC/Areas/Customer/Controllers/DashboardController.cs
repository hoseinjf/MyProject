using AppDomainCore.Customers.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Customer.Controllers
{
	[Authorize(Roles = "Customer")]
	[Area(areaName: "Customer")]
	public class DashboardController : Microsoft.AspNetCore.Mvc.Controller
	{
		private readonly ICustomerAppService _customerAppService;
        public DashboardController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

		public async Task<IActionResult> Index( int id,CancellationToken cancellationToken)
		{
			var result = await _customerAppService.Get(id, cancellationToken);
            ViewBag.Customer = result;
            return View();
		}
	}
}
