using AppDomainCore.Comments.Contract.AppService;
using AppDomainCore.Comments.Contract.Service;
using AppDomainCore.Comments.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Comments
{
    public class CommentAppService : ICommentAppService
    {
        private readonly ICommentService _commentService;
        public CommentAppService(ICommentService commentService)
        {
            _commentService = commentService;
        }
        public async Task<Comment> Add(Comment comment, CancellationToken cancellationToken)
        {
            return await _commentService.Add(comment, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _commentService.Delete(id, cancellationToken);
        }

        public async Task<Comment> Get(int id, CancellationToken cancellationToken)
        {
            return await _commentService.Get(id, cancellationToken);
        }

        public async Task<List<Comment>> GetUser(int Id, CancellationToken cancellationToken)
        {
	        return await _commentService.GetUser(Id, cancellationToken);

		}


		public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            return await _commentService.GetAll(cancellationToken);
        }

        public async Task<Comment> Update(Comment comment, CancellationToken cancellationToken)
        {
            return await _commentService.Update(comment, cancellationToken);
        }
    }
}
