using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppEndpoint_MVC.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly ICategoryAppService _categoryAppService;
        private readonly ILogger<HomeController> _logger;

        public CategoryController(ICategoryAppService category, ILogger<HomeController> logger)
        {
            _categoryAppService = category;
            _logger = logger;
        }

        public async Task<IActionResult> Index(List<Category> categories, CancellationToken cancellationToken)
        {
            _logger.LogInformation("صفحه اصلی کتگوری در پنل ادمین در تاریخ:{date}بازدید شد", DateTime.UtcNow.ToLongDateString());
            categories = await _categoryAppService.GetAll(cancellationToken);
            return View(categories);

        }

        public async Task<IActionResult> Add(CancellationToken cancellationToken)
        {
            _logger.LogInformation("صفحه اضافه کردن کتگوری در پنل ادمین در تاریخ:{date}بازدید شد", DateTime.UtcNow.ToLongDateString());

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
            CategoryDto categoryDto = new CategoryDto();
            categoryDto.Title = x.Title;
            categoryDto.subCategories = x.subCategories;
            categoryDto.Id = x.Id;
            categoryDto.Photo = x.Photo;
            return View(categoryDto);
        }

        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categories, CancellationToken cancellationToken)
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
