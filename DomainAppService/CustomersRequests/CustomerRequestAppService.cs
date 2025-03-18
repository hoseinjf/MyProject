using AppDomainCore.CustomersRequests.Contract.AppService;
using AppDomainCore.CustomersRequests.Contract.Service;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.CustomersRequests.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.CustomersRequests
{
    public class CustomerRequestAppService : ICustomerRequestAppService
    {
        private readonly ICustomerRequestService _service;
        public CustomerRequestAppService(ICustomerRequestService customer)
        {
            _service = customer;
        }
        public async Task<CustomersRequest> Add(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            return await _service.Add(customersRequest, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _service.Delete(id, cancellationToken);
        }

        public async Task<CustomersRequest> Get(int id, CancellationToken cancellationToken)
        {
            return await _service.Get(id, cancellationToken);
        }

        public async Task<CustomersRequest> EndhJob(int Id, CancellationToken cancellationToken)
        {
            var request = await _service.Get(Id, cancellationToken);
            request.Status = StatusEnum.waiting;
            return await _service.Update(request, cancellationToken);
        }

        public async Task<List<CustomersRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _service.GetAll(cancellationToken);
        }

        public async Task<List<CustomersRequest>> GetAllId(int id, CancellationToken cancellationToken)
        {
	        return await _service.GetAllId(id,cancellationToken);
		}

		public async Task<CustomersRequest> Update(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {

            return await _service.Update(customersRequest,cancellationToken);
        }
    }
}
