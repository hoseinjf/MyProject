using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.Contract.Service;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.Customers
{
    public class CustomerAppService : ICustomerAppService
    {
        private readonly ICustomerService _customerService;
        public CustomerAppService(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        public async Task<Customer> Add(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            return await _customerService.Add(customer, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _customerService.Delete(id, cancellationToken);
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            return await _customerService.Get(id, cancellationToken);
        }

        public async Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            return await _customerService.GetAll(cancellationToken);
        }

        public async Task<Customer> Update(Customer customer, CancellationToken cancellationToken)
        {
            return await _customerService.Update(customer, cancellationToken);
        }
    }
}
