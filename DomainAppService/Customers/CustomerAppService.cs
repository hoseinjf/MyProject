using AppDomainCore.Base;
using AppDomainCore.Customers.Contract.AppService;
using AppDomainCore.Customers.Contract.Service;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Works.Contract.Repository;
using AppDomainCore.Works.Entity;
using Microsoft.EntityFrameworkCore.Diagnostics;
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
        private readonly IBaseDataService _bas;
        public CustomerAppService(ICustomerService customerService,IBaseDataService bb)
        {
            _bas = bb;
            _customerService = customerService;
        }
        public async Task<Customer> Add(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            customer.Photo = new AppDomainCore.Photos.Entity.Photo()
            {
                Src= await _bas.UploadImage(customer.Pic, "customer", cancellationToken),
                
            };
            //customer.Photo.Src= await _bas.UploadImage(customer.Pic,"customer",cancellationToken);
            
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

        public async Task<Customer> Update(CustomerAddDto customer, CancellationToken cancellationToken)
        {
            if (customer.Pic != null)
            {
                customer.Photo = new AppDomainCore.Photos.Entity.Photo()
                {
                    Src = await _bas.UploadImage(customer.Pic, "customer", cancellationToken),
                };
            }
            return await _customerService.Update( customer, cancellationToken);
        }
		public async Task<CustomerAddDto> GetUpdateDTO(int Id, CancellationToken cancellationToken)
		{
			var com = await _customerService.GetUpdateDTO(Id, cancellationToken);
			return com;
		}
	}
}
