using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.CustomersRequests.Enum;
using Hangfire.Server;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CustomersRequestController : Controller
    {
        private readonly ICustomerRequestAppService _appService;
        public CustomersRequestController(ICustomerRequestAppService customerRequestAppService)
        {
            _appService = customerRequestAppService;
        }

        public async Task<IActionResult> Index(List<CustomersRequest> customers, CancellationToken cancellationToken)
        {
            customers = await _appService.GetAll(cancellationToken);
            return View(customers);
        }

        public async Task<IActionResult> Get(int id, CancellationToken cancellationToken)
        {
            var x = await _appService.Get(id,cancellationToken);
            return View(x);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _appService.Get(id, cancellationToken);

            ViewBag.StatusList = Enum.GetValues(typeof(StatusEnum))
                .Cast<StatusEnum>()
                .Select(e => new SelectListItem
                {
                Value = ((int)e).ToString(),
                Text = e.ToString(),
                Selected = (e == x.Status)
                }).ToList();

            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CustomersRequest customer, CancellationToken cancellationToken)
        {
            var item = await _appService.Update(customer, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
