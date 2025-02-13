using AppDataRepository.Db;
using AppDomainCore.Comments.Contract.Repository;
using AppDomainCore.Comments.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            await _db.Comments.AddAsync(comment,cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return comment;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(c => c.Id == id,cancellationToken);
            _db.Comments.Remove(comment);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<Comment> Get(int id, CancellationToken cancellationToken)
        {
            var comment = await _db.Comments.FirstOrDefaultAsync(c=>c.Id==id,cancellationToken);
            return comment;
        }

        public async Task<List<Comment>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Comments.ToListAsync(cancellationToken);
        }

        public async Task<Comment> Update(Comment comment, CancellationToken cancellationToken)
        {
            _db.Comments.Update(comment);
            await _db.SaveChangesAsync(cancellationToken);
            return comment;
        }
    }
}
