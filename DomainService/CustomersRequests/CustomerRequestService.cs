using AppDomainCore.Customers.Contract.Repository;
using AppDomainCore.Customers.Contract.Service;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Contract.Repository;
using AppDomainCore.CustomersRequests.Contract.Service;
using AppDomainCore.CustomersRequests.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.CustomersRequests
{
    public class CustomerRequestService : ICustomerRequestService
    {
        private readonly ICustomerRequestRepository _repository;

        public CustomerRequestService(ICustomerRequestRepository customerRepository)
        {
            _repository = customerRepository;
        }

        public async Task<CustomersRequest> Add(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            var com =await _repository.Add(customersRequest, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _repository.Delete(id, cancellationToken);
        }

        public async Task<CustomersRequest> Get(int id, CancellationToken cancellationToken)
        {
            var com = await _repository.Get(id, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<List<CustomersRequest>> GetAll(CancellationToken cancellationToken)
        {
            var com = await _repository.GetAll( cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<CustomersRequest> Update(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            var com = await _repository.Update(customersRequest, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }
    }
}
