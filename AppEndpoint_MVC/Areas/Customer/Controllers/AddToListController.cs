using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.Provinces.Contract.AppService;
using AppDomainCore.Works.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Customer.Controller
{
	[Authorize(Roles = "Customer")]
	[Area(areaName: "Customer")]
	public class AddToListController : Microsoft.AspNetCore.Mvc.Controller
	{
		private readonly ICustomerAppService _customerAppService;
        private readonly IWorkAppService _serviceAppService;
        private readonly IprovinceAppService _cityAppService;
        private readonly ICustomerRequestAppService _customerRequestAppService;
        public AddToListController(ICustomerAppService customerAppService, IWorkAppService workAppService, IprovinceAppService iprovinceAppService, ICustomerRequestAppService customerRequestApp)
        {
			_customerAppService = customerAppService;
            _serviceAppService = workAppService;
            _cityAppService = iprovinceAppService;
            _customerRequestAppService = customerRequestApp;
        }
        public async Task<IActionResult> Index(int id, int ServiceId, CancellationToken cancellationToken)
        {
            var Customer = await _customerAppService.Get(id, cancellationToken);
            ViewBag.Customer = Customer;
            var Services = await _serviceAppService.GetAll(cancellationToken);
            ViewBag.Services = Services;
            var Cities = await _cityAppService.GetAll(cancellationToken);
            ViewBag.Cities = Cities;
            ViewBag.ServiceId = ServiceId;

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRequest(CustomersRequest addRequest, CancellationToken cancellationToken)
        {
            var result = await _customerRequestAppService.Add(addRequest, cancellationToken);
            return LocalRedirect($"/Customer/Dashboard/Index/{addRequest.CustomerId}");
        }
    }
}
