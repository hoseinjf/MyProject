using AppDomainCore.Categorys.Contract.AppService;
using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.Works.Contract.AppService;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoin_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class CategoryController : ControllerBase
	{
		private readonly ICategoryAppService _categoryAppService;
		private readonly ISubCategoryAppService _subCategory;
		private readonly IWorkAppService _workAppService;

		public CategoryController(ICategoryAppService categoryAppService, ISubCategoryAppService subCategory, IWorkAppService workAppService)
		{
			_categoryAppService = categoryAppService;
			_subCategory = subCategory;
			_workAppService = workAppService;
		}

		[HttpGet("GetCategories")]
		public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
		{
			var categories = await _categoryAppService.GetAll(cancellationToken);
			return Ok(categories);
		}

		[HttpGet("GetSubCategories")]
		public async Task<IActionResult> GetSubCategories( CancellationToken cancellationToken)
		{
			var SubCategories = await _subCategory.GetAll(cancellationToken);
			return Ok(SubCategories);
		}

		[HttpGet("GetWorks")]
		public async Task<IActionResult> GetWorks( CancellationToken cancellationToken)
		{
			var Work = await _workAppService.GetAll(cancellationToken);
			return Ok(Work);
		}
	}
}
