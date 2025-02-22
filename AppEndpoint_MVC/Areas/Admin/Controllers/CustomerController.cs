using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Provinces.Contract.AppService;
using AppEndpoint_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IprovinceAppService _pr;
        public CustomerController(ICustomerAppService customerAppService, IprovinceAppService prr)
        {
            _customerAppService = customerAppService;
            _pr = prr;
        }

        public async Task<IActionResult> Index(List<Customer> customers,CancellationToken cancellationToken)
        {
                customers = await _customerAppService.GetAll(cancellationToken);
                return View(customers);   
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken) 
        {
            var categories = await _pr.GetAll(cancellationToken);
            ViewBag.Categories = categories;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerAddDto customer,CancellationToken cancellationToken)
        {
            var item= await _customerAppService.Add(customer,cancellationToken);
            return RedirectToAction("Index");
        }

        public async  Task<IActionResult> Update(int id,CancellationToken cancellationToken)
        {
            var x = await _customerAppService.Get(id, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer customer, CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Update( customer, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id , CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }

    }
}
