using AppDomainCore.Account.AppService;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Contract.AppService;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Provinces.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class ExpertController : Controller
    {
        private readonly IExpertAppService _expertAppService;
        private readonly IprovinceAppService _pr;
        private readonly IAccountAppService _accountAppService;

        public ExpertController(IExpertAppService expertApp, IprovinceAppService iprovinceApp, IAccountAppService accountAppService)
        {
            _expertAppService = expertApp;
            _pr = iprovinceApp;
            _accountAppService = accountAppService;
        }


        public async Task<IActionResult> Index(List<Expert> experts, CancellationToken cancellationToken)
        {
            experts = await _expertAppService.GetAll(cancellationToken);
            return View(experts);
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            var provinces = await _pr.GetAll(cancellationToken);
            ViewBag.Provinces = provinces;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExpertAddDto expert, CancellationToken cancellationToken)
        {
            var item = await _accountAppService.RegisterExpert(expert, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _expertAppService.Get(id, cancellationToken);

            ExpertAddDto expertAddDto = new ExpertAddDto();
            expertAddDto.Id = x.Id;
            expertAddDto.UserId = x.User.Id;
            expertAddDto.FirstName = x.User.FirstName;
            expertAddDto.LastName = x.User.LastName;
            expertAddDto.Email = x.User.Email;
            expertAddDto.Address = x.User.Address;
            expertAddDto.UserName = x.User.UserName;
            expertAddDto.Email = x.User.NormalizedEmail;
            expertAddDto.UserName = x.User.NormalizedUserName;
            expertAddDto.Phone = x.User.Phone;
            expertAddDto.Photo = x.User.Photo;
            expertAddDto.CityId = x.User.ProvinceId;

            return View(expertAddDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ExpertAddDto expert, CancellationToken cancellationToken)
        {
            var item = await _expertAppService.Update(expert, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var item = await _expertAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }

    }
}
