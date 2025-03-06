using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.Works.Contract.AppService;
using AppEndpoint_MVC.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading;

namespace AppEndpoint_MVC.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICategoryAppService _categoryAppService;
        private readonly ISubCategoryAppService _subCategoryAppService;
        private readonly IWorkAppService _workAppService;

        public HomeController(ILogger<HomeController> logger, ICategoryAppService categoryApp, ISubCategoryAppService subCategoryApp, IWorkAppService workApp)
        {
            _logger = logger;
            _categoryAppService = categoryApp;
            _subCategoryAppService = subCategoryApp;
            _workAppService = workApp;
        }

        public async Task <IActionResult> Index(CancellationToken cancellationToken)
        {
			var Categories = await _categoryAppService.GetAll(cancellationToken);
			ViewBag.Categories = Categories;
			var SubCategories = await _subCategoryAppService.GetAll(cancellationToken);
			ViewBag.SubCategories = SubCategories;
			var Services = await _workAppService.GetAll(cancellationToken);
			ViewBag.Services = Services;
			return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
