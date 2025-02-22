using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
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
        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;
        }

        public async Task<IActionResult> Index(List<Customer> customers,CancellationToken cancellationToken)
        {
                customers = await _customerAppService.GetAll(cancellationToken);
                return View(customers);   
        }

        public IActionResult Add() 
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerAddDto customer,CancellationToken cancellationToken)
        {
            var item= await _customerAppService.Add(customer,cancellationToken);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Update(Customer customer, CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Update(customer, cancellationToken);
            return View("Index");
        }

        public async Task<IActionResult> Delete(int id , CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Delete(id, cancellationToken);
            return View("Index");
        }

    }
}
