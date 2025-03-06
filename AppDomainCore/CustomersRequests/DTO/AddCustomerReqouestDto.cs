using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Enum;
using AppDomainCore.Photos.Entity;
using AppDomainCore.Works.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.CustomersRequests.DTO
{
	public class AddCustomerReqouestDto
	{
		public int Id { get; set; }
		public DateTime DateWork { get; set; }
		public string Description { get; set; }
		public List<Photo>? Photo { get; set; } = new List<Photo>();
		public int WorkId { get; set; }
		public int CustomerId { get; set; }
		public StatusEnum Status { get; set; }
		public List<IFormFile>? ImageFiles { get; set; }
	}
}
