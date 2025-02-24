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
        public ExpertController(IExpertAppService expertApp, IprovinceAppService iprovinceApp)
        {
            _expertAppService = expertApp;
            _pr = iprovinceApp;
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
            var item = await _expertAppService.Add(expert, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _expertAppService.Get(id, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Expert expert, CancellationToken cancellationToken)
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
