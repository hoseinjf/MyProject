using AppDomainCore.Categorys.Entity;
using AppDomainCore.Comments.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Comments.Contract.AppService
{
    public interface ICommentAppService
    {
        public Task<Comment> Get(int id, CancellationToken cancellationToken);
        public Task<List<Comment>> GetAll(CancellationToken cancellationToken);
        public Task<Comment> Add(Comment comment, CancellationToken cancellationToken);
        public Task<Comment> Update(Comment comment, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
    }
}
