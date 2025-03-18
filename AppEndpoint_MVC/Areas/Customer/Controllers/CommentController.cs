using AppDomainCore.Comments.Contract.AppService;
using AppDomainCore.Comments.Entity;
using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.ExpertsRequests.Contract.AppService;
using DomainAppService.Comments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Customer.Controllers
{
    [Authorize(Roles = "Customer")]
    [Area(areaName: "Customer")]
    public class CommentController : Microsoft.AspNetCore.Mvc.Controller
	{
		private readonly ICommentAppService _appService;
		private readonly ICustomerAppService _customerAppService;
		private readonly ICustomerRequestAppService _customerRequestAppService;
        private readonly IExpertsRequestAppService _expertsRequestAppService;

		public CommentController(ICommentAppService appService, ICustomerAppService customerAppService, ICustomerRequestAppService customerRequestAppService, IExpertsRequestAppService expertsRequestAppService)
		{
			_appService = appService;
			_customerAppService = customerAppService;
			_customerRequestAppService = customerRequestAppService;
            _expertsRequestAppService = expertsRequestAppService;
        }

		public async Task<IActionResult> Index(int id, CancellationToken cancellationToken)
		{
			var Customer = await _customerAppService.Get(id, cancellationToken);
			ViewBag.Customer = Customer;
			var result = await _appService.GetUser(id, cancellationToken);
			return View(result);
		}

        public async Task<IActionResult> AddComments(int id, int reqId, CancellationToken cancellationToken)
        {
            var Customer = await _customerAppService.Get(id, cancellationToken);
            ViewBag.Customer = Customer;
            var req = await _expertsRequestAppService.Get(reqId, cancellationToken);
            ViewBag.req = req;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Addcomments(Comment addComment, CancellationToken cancellationToken)
        {
            var result = await _appService.Add(addComment, cancellationToken);
            return LocalRedirect($"/Customer/Comment/Index/{addComment.CustomersId}");
        }


    }
}
