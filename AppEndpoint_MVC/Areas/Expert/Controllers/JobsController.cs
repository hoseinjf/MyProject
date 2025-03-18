using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.Experts.Contract.AppService;
using AppDomainCore.ExpertsRequests.Contract.AppService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Expert.Controllers
{
    [Authorize(Roles = "Expert")]
    [Area(areaName: "Expert")]
    public class JobsController : Controller
    {
        private readonly IExpertAppService _expertAppService;
        private readonly IExpertsRequestAppService _expertsRequestAppService;
        private readonly ICustomerRequestAppService _customerRequestAppService;

        public JobsController(IExpertAppService expertAppService, IExpertsRequestAppService expertsRequestAppService, ICustomerRequestAppService customerRequestAppService)
        {
            _expertAppService = expertAppService;
            _expertsRequestAppService = expertsRequestAppService;
            _customerRequestAppService = customerRequestAppService;
        }

        public async Task<IActionResult> Index(int Id, CancellationToken cancellationToken)
        {
            var expert = await _expertAppService.Get(Id, cancellationToken);
            ViewBag.Expert = expert;
            var result = await _expertsRequestAppService.GetAllExpert(Id, cancellationToken);
            return View(result);
        }
        public async Task<IActionResult> EndJob(int Id, int RequestId, CancellationToken cancellationToken)
        {
            await _customerRequestAppService.EndhJob(RequestId, cancellationToken);
            return LocalRedirect($"/Expert/Jobs/Index/{Id}");
        }

    }
}
