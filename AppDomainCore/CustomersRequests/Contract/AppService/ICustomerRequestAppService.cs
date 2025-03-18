using AppDomainCore.CustomersRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CustomersRequests.Contract.AppService
{
    public interface ICustomerRequestAppService
    {
        public Task<CustomersRequest> Get(int id, CancellationToken cancellationToken);
        public Task<List<CustomersRequest>> GetAll(CancellationToken cancellationToken);
        public Task<CustomersRequest> Add(CustomersRequest customersRequest, CancellationToken cancellationToken);
        public Task<CustomersRequest> Update(CustomersRequest customersRequest, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
        public Task<CustomersRequest> EndhJob(int Id, CancellationToken cancellationToken);
        public  Task<List<CustomersRequest>> GetAllId(int id, CancellationToken cancellationToken);

    }
}
