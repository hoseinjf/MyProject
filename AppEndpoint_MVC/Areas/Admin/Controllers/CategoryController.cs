using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryAppService;
        public CategoryController(ICategoryAppService category)
        {
            _categoryAppService = category;
        }

        public async Task<IActionResult> Index(List<Category> categories, CancellationToken cancellationToken)
        {
            categories = await _categoryAppService.GetAll(cancellationToken);
            return View(categories);
        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(CategoryDto categories, CancellationToken cancellationToken)
        {
            var item = await _categoryAppService.Add(categories, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _categoryAppService.Get(id, cancellationToken);
            return View(x);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category categories, CancellationToken cancellationToken)
        {
            var item = await _categoryAppService.Update(categories, cancellationToken);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int id, CancellationToken cancellationToken)
        {
            var item = await _categoryAppService.Delete(id, cancellationToken);
            return RedirectToAction("Index");
        }
    }
}
