using AppDomainCore.Experts.Contract.AppService;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Provinces.Contract.AppService;
using AppDomainCore.Works.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Expert.Controllers
{
	[Authorize(Roles = "Expert")]
	[Area(areaName: "Expert")]
	public class UpdateProfileController : Controller
    {
        private readonly IExpertAppService _expertAppService;
        private readonly IprovinceAppService _provinceAppService;
        private readonly IWorkAppService _workAppService;

        public UpdateProfileController(IExpertAppService expertAppService, IprovinceAppService provinceAppService, IWorkAppService workAppService)
        {
            _expertAppService = expertAppService;
            _provinceAppService = provinceAppService;
            _workAppService = workAppService;
        }

        public async Task<IActionResult> Index(int Id, CancellationToken cancellationToken)
        {
            var expert = await _expertAppService.Get(Id, cancellationToken);
            ViewBag.Expert = expert;
            var services = await _workAppService.GetAll(cancellationToken);
            ViewBag.Services = services;
            var city = await _provinceAppService.GetAll(cancellationToken);
            ViewBag.city = city;
            var Update = await _expertAppService.GetUpdate(Id, cancellationToken);

            return View(Update);
        }
        [HttpPost]
        public async Task<IActionResult> Update(ExpertUpdateProfileDto updateExpert, CancellationToken cancellationToken)
        {
            await _expertAppService.UpdateProfile(updateExpert, cancellationToken);
            return LocalRedirect($"/Expert/Dashboard/Index/{updateExpert.Id}");
        }


    }
}
