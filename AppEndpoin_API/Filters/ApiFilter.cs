using AppDomainCore.SiteSetting;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoin_API.Filters
{
	public class ApiFilter : ActionFilterAttribute
	{
		private readonly SiteSettings _siteSettings;

		public ApiFilter(SiteSettings siteSettings)
		{
			_siteSettings = siteSettings;
		}

		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var apiKey = context.HttpContext.Request.Headers["apikey"].ToString();
			if (apiKey == null || apiKey != _siteSettings.ApiKey)
			{
				context.Result = new UnauthorizedObjectResult(new { message = "apikey  وارد شده اشتباه میباشد" });
			}
		}

	}
}
