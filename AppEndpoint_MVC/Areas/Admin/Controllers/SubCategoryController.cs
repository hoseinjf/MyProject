using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.SubCategorys.DTO;
using AppDomainCore.SubCategorys.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class SubCategoryController : Controller
    {
        private readonly ISubCategoryAppService _subCategoryAppService;
        public SubCategoryController(ISubCategoryAppService subCategoryAppService)
        {
            _subCategoryAppService = subCategoryAppService;
        }
        public async Task<IActionResult> Index(List<SubCategory> categories, CancellationToken cancellationToken)
        {
            categories = await _subCategoryAppService.GetAll(cancellationToken);
            return View(categories);
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(SubCategoryDto categories, CancellationToken cancellationToken)
        {
            var item = await _subCategoryAppService.Add(categories, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _subCategoryAppService.Get(id, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(SubCategory categories, CancellationToken cancellationToken)
        {
            var item = await _subCategoryAppService.Update(categories, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var item = await _subCategoryAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
