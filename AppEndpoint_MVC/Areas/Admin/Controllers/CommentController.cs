using AppDomainCore.Categorys.DTO;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.Comments.Contract.AppService;
using AppDomainCore.Comments.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AppEndpoint_MVC.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]
    [Area("Admin")]
    public class CommentController : Controller
    {
        private readonly ICommentAppService _appService;
        public CommentController(ICommentAppService commentAppService)
        {
            _appService = commentAppService;
        }

        public async Task<IActionResult> Index(List<Comment> comments, CancellationToken cancellationToken)
        {
            comments = await _appService.GetAll(cancellationToken);
            return View(comments);
        }

        public async Task<IActionResult> Update(int id, CancellationToken cancellationToken)
        {
            var x = await _appService.Get(id, cancellationToken);
            var item = await _appService.Update(x, cancellationToken);
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public async Task<IActionResult> Update(Comment comment, CancellationToken cancellationToken)
        //{
        //}
    }
}
