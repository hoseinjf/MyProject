using AppDomainCore.SubCategorys.Contract.AppService;
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
        private readonly ISubCategoryAppService _subCategoryAppService;
        public WorkController(IWorkAppService workAppService, ISubCategoryAppService subCategoryAppService)
        {
            _workAppService = workAppService;
            _subCategoryAppService = subCategoryAppService;

        }

        public async Task<IActionResult> Index(List<Work> work, CancellationToken cancellationToken)
        {
            work = await _workAppService.GetAll(cancellationToken);
            return View(work);
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            var x =await _subCategoryAppService.GetAll(cancellationToken);
            ViewBag.Work = x;
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
            var x2 = await _subCategoryAppService.GetAll(cancellationToken);
            ViewBag.Work = x2;
            WorkDto workDto = new WorkDto();
            workDto.Id = x.Id;
            workDto.CorePrice = x.CorePrice;
            workDto.Photo = x.Photo;
            workDto.Description = x.Description;
            workDto.Title = x.Title;
            workDto.Viwe = x.Viwe;
            workDto.SubCategoryId = x.SubCategoryId;
            return View(workDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(WorkDto work, CancellationToken cancellationToken)
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
