using AppDomainCore.Account.AppService;
using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Provinces.Contract.AppService;
using AppDomainCore.Provinces.Entity;
using AppEndpoint_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.Net;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly ICustomerAppService _customerAppService;
        private readonly IprovinceAppService _pr;
        private readonly IAccountAppService _accountAppService;
        public CustomerController(ICustomerAppService customerAppService, IprovinceAppService prr, IAccountAppService accountAppService)
        {
            _customerAppService = customerAppService;
            _pr = prr;
            _accountAppService = accountAppService;
        }

		public async Task<IActionResult> Index(List<AppDomainCore.Customers.Entity.Customer> customers, CancellationToken cancellationToken)
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
        public async Task<IActionResult> Add(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            var item = await _accountAppService.RegisterCustomer(customer, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _customerAppService.Get(id, cancellationToken);
            CustomerAddDto customerAddDto = new CustomerAddDto();
            customerAddDto.FirstName = x.User.FirstName;
            customerAddDto.LastName = x.User.LastName;
            customerAddDto.Email = x.User.Email;
            customerAddDto.Address = x.User.Address;
            customerAddDto.UserName = x.User.UserName;
            customerAddDto.Email = x.User.NormalizedEmail;
            customerAddDto.UserName = x.User.NormalizedUserName;
            customerAddDto.Phone = x.User.Phone;
            customerAddDto.Photo = x.User.Photo;
            customerAddDto.CityId = x.User.ProvinceId;
            customerAddDto.UserId = x.User.Id;
            customerAddDto.Id = x.Id;

            var categories = await _pr.GetAll(cancellationToken);
            ViewBag.Categories = categories;

            return View(customerAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Update(customer, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var item = await _customerAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }

    }
}
