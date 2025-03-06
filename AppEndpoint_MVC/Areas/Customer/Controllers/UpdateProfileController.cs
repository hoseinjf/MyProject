using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Customer.Controllers
{
	[Authorize(Roles = "Customer")]
	[Area(areaName: "Customer")]
	public class UpdateProfileController : Microsoft.AspNetCore.Mvc.Controller
	{
		private readonly ICustomerAppService _customerAppService;

		public UpdateProfileController(ICustomerAppService customerAppService)
		{
			_customerAppService = customerAppService;
		}

		public async Task<IActionResult> Index(int Id, CancellationToken cancellationToken)
		{
			var Customer = await _customerAppService.Get(Id, cancellationToken);
			ViewBag.Customer = Customer;
			var result = await _customerAppService.GetUpdateDTO(Id, cancellationToken);
			return View(result);
		}
		[HttpPost]
		public async Task<IActionResult> Update(CustomerAddDto customerAddDto, CancellationToken cancellationToken)
		{
			await _customerAppService.Update(customerAddDto, cancellationToken);
			return LocalRedirect($"/Customer/Dashboard/Index/{customerAddDto.Id}");
		}
	}
}
