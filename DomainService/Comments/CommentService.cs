using AppDomainCore.Categorys.Contract.Repository;
using AppDomainCore.Comments.Contract.Repository;
using AppDomainCore.Comments.Contract.Service;
using AppDomainCore.Comments.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Comments
{
    public class CommentService:ICommentService
    {
        private readonly ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<Comment> Add(Comment comment, CancellationToken cancellationToken)
        {
            var com = await _commentRepository.Add(comment, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _commentRepository.Delete(id, cancellationToken);
        }

        public async Task<Comment> Get(int id, CancellationToken cancellationToken)
        {
            var com = await _commentRepository.Get(id, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<List<Comment>> GetUser(int Id, CancellationToken cancellationToken)
        {
	        var com = await _commentRepository.GetUser(Id, cancellationToken);
	        if (com == null) throw new ArgumentNullException("موردی یافت نشد");
	        return com;
		}


		public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            var com =await _commentRepository.GetAll( cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<Comment> Update(Comment comment, CancellationToken cancellationToken)
        {
            var com =await _commentRepository.Update(comment, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }
    }
}
