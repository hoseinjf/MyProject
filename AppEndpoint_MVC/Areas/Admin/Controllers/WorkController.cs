using AppDomainCore.SubCategorys.DTO;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Works.Contract.AppService;
using AppDomainCore.Works.DTO;
using AppDomainCore.Works.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class WorkController : Controller
    {
        private readonly IWorkAppService _workAppService;
        public WorkController(IWorkAppService workAppService)
        {
            _workAppService = workAppService;
        }

        public async Task<IActionResult> Index(List<Work> work, CancellationToken cancellationToken)
        {
            work = await _workAppService.GetAll(cancellationToken);
            return View(work);
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(WorkDto workDto, CancellationToken cancellationToken)
        {
            var item = await _workAppService.Add(workDto, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _workAppService.Get(id, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Work work, CancellationToken cancellationToken)
        {
            var item = await _workAppService.Update(work, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var item = await _workAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
