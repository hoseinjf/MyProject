using AppDomainCore.CustomersRequests.Contract.AppService;
using AppEndpoin_API.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoin_API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RequestController : ControllerBase
	{
		private readonly ICustomerRequestAppService _customerRequestAppService;

		public RequestController(ICustomerRequestAppService customerRequestAppService)
		{
			_customerRequestAppService = customerRequestAppService;
		}

		[HttpGet("AllRequest")]
		[ServiceFilter(typeof(ApiFilter))]
		public async Task<IActionResult> AllRequests([FromHeader] string? apikey, CancellationToken cancellationToken)
		{
			var request = await _customerRequestAppService.GetAll(cancellationToken);

			if (request == null || request.Count == 0)
			{
				return NotFound(new { message = "هیچ درخواستی یافت نشد." });
			}
			return Ok(request);
		}

	}
}
