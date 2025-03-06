using AppDomainCore.SubCategorys.Contract.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Controllers
{
	public class SubCategoryController : Controller
	{
		private readonly ISubCategoryAppService _subCategoryAppService;
        public SubCategoryController(ISubCategoryAppService subCategoryAppService)
        {
            _subCategoryAppService = subCategoryAppService;
        }
        public async Task <IActionResult> Index(int id,CancellationToken cancellationToken)
		{
			var SubCategories = await _subCategoryAppService.GetAllId(id,cancellationToken);
			ViewBag.SubCategories = SubCategories;
			return View();
		}
	}
}
