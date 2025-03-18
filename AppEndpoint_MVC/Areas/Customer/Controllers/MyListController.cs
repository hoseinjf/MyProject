using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.ExpertsRequests.Contract.AppService;
using AppDomainCore.ExpertsRequests.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Customer.Controllers
{
	[Authorize(Roles = "Customer")]
	[Area(areaName: "Customer")]
	public class MyListController : Microsoft.AspNetCore.Mvc.Controller
	{
		private readonly IExpertsRequestAppService _appService;
		private readonly ICustomerRequestAppService _customerAppService;

		public MyListController(IExpertsRequestAppService appService, ICustomerRequestAppService customerAppService)
		{
			_appService = appService;
			_customerAppService = customerAppService;
		}

		public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
		{
			var Customer = await _customerAppService.GetAllId(id, cancellationToken);
			if (Customer == null)
			{
				Customer = new List<AppDomainCore.CustomersRequests.Entity.CustomersRequest>();
			}
			return View(Customer);
		}

		public async Task<IActionResult> GetRequest(int id, CancellationToken cancellationToken)
		{
			var Customer = await _customerAppService.Get(id, cancellationToken);
			if (Customer == null)
			{
				Customer = new AppDomainCore.CustomersRequests.Entity.CustomersRequest();
			}
			
            ViewBag.co = Customer;
			var rx = _appService.GetAllCustomerRequest(id, cancellationToken);

            ViewBag.ex = rx;
            return View(rx);
		}

       

    }
}
