using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Customers.Contract.Service
{
    public interface ICustomerService
    {
        public Task<Customer> Get(int id, CancellationToken cancellationToken);
        public Task<List<Customer>> GetAll(CancellationToken cancellationToken);
        public Task<Customer> Add(CustomerAddDto customer, CancellationToken cancellationToken);
        public Task<Customer> Update(CustomerAddDto customer, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
		public Task<CustomerAddDto> GetUpdateDTO(int Id, CancellationToken cancellationToken);

	}
}
