using AppDomainCore.Comments.Contract.Repository;
using AppDomainCore.Comments.Entity;
using AppDomainCore.Customers.Contract.Repository;
using AppDomainCore.Customers.Contract.Service;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainService.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public async Task<Customer> Add(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            var com =await _customerRepository.Add(customer, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _customerRepository.Delete(id, cancellationToken);
        }

        public async Task<Customer> Get(int id, CancellationToken cancellationToken)
        {
            var com = await _customerRepository.Get(id, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public Task<List<Customer>> GetAll(CancellationToken cancellationToken)
        {
            var com =  _customerRepository.GetAll( cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }

        public async Task<Customer> Update(Customer customer, CancellationToken cancellationToken)
        {
            var com = await _customerRepository.Update(customer, cancellationToken);
            if (com == null) throw new ArgumentNullException("موردی یافت نشد");
            return com;
        }
    }
}
