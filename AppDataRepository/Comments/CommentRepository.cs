using AppDataRepository.Db.Context;
using AppDomainCore.Admins.Entity;
using AppDomainCore.Comments.Contract.Repository;
using AppDomainCore.Comments.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDomainCore.Comments.DTO;

namespace AppDataRepository.Comments
{
    public class CommentRepository : ICommentRepository
    {
        private readonly AppDbContext _db;
        public CommentRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public async Task<Comment> Add(Comment comment, CancellationToken cancellationToken)
        {
            try
            {
                await _db.Comments.AddAsync(comment, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return comment;
            }
            catch (Exception ex) 
            {
                return new Comment();
            }
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(c => c.Id == id,cancellationToken);
            if (comment == null) { return false; }
            _db.Comments.Remove(comment);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Comment> Get(int id, CancellationToken cancellationToken)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(c=>c.Id==id,cancellationToken);
            if (comment == null) { throw new Exception("کامنت یافت نشد"); }
            return comment;
        }

        public async Task<List<Comment>> GetUser(int Id, CancellationToken cancellationToken)
        {
	        var result = await _db.Comments.Where(x => x.CustomersId == Id && x.IsActive == true).Select(x => new Comment
			{
		        Id = x.Id,
		        Title = x.Title,
		        Description = x.Description,
		        WorkScore = x.WorkScore,
		        IsActive = x.IsActive,
		        Customers = x.Customers,
		        Experts = x.Experts,
		        IsDelete = x.IsDelete,
				CreateAt = x.CreateAt

	        }).ToListAsync(cancellationToken);
	        return result;
        }

		public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Comments.ToListAsync(cancellationToken);
        }

        public async Task<Comment> Update(Comment model, CancellationToken cancellationToken)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (comment == null) { throw new Exception("کامنت یافت نشد"); }
            //comment.Title = model.Title;
            //comment.Description = model.Description;
            //comment.WorkScore = model.WorkScore;
            if (comment.IsActive == true)
            {
                comment.IsActive=false;
                comment.IsActive = model.IsActive;
                await _db.SaveChangesAsync(cancellationToken);
                return comment;
            }
            else
            {
                comment.IsActive = true;
                comment.IsActive = model.IsActive;
                await _db.SaveChangesAsync(cancellationToken);
                return comment;
            }
        }
    }
}
