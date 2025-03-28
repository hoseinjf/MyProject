﻿using AppDataRepository.Db.Context;
using AppDomainCore.Customers.Entity;
using AppDomainCore.CustomersRequests.Contract.Repository;
using AppDomainCore.CustomersRequests.Entity;
using AppDomainCore.CustomersRequests.Enum;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.CustomersRequests
{
    public class CustomerRequestRepository : ICustomerRequestRepository
    {
        private readonly AppDbContext _db;
        public CustomerRequestRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        public async Task<CustomersRequest> Add(CustomersRequest customersRequest, CancellationToken cancellationToken)
        {
            try
            {
                await _db.CustomersRequests.AddAsync(customersRequest, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return customersRequest;
            }
            catch (Exception ex) { return new CustomersRequest(); }
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var request = await _db.CustomersRequests.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (request == null) { return false; }
            _db.CustomersRequests.Remove(request);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<CustomersRequest> Get(int id, CancellationToken cancellationToken)
        {
            var request = await _db.CustomersRequests.Include(x => x.Work)
                .Include(x => x.Work.Experts)
                .Include(x => x.Customer.User)
                .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (request == null) { throw new Exception("درخواستی یافت نشد"); }

            return request;
        }

        public async Task<List<CustomersRequest>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.CustomersRequests.Include(x => x.Work).Include(x => x.Work.Experts).Include(x => x.Customer.User).Include(x => x.Customer.User.Photo).ToListAsync(cancellationToken);
        }

        public async Task<List<CustomersRequest>> GetAllId(int id,CancellationToken cancellationToken)
        {
	        return await _db.CustomersRequests.Include(x => x.Work)
		        .Include(x => x.Work.Experts)
		        .Include(x => x.Customer.User)
		        .Include(x => x.Customer.User.Photo)
		        .Where(x=>x.CustomerId==id)
		        .ToListAsync(cancellationToken);
        }

		public async Task<CustomersRequest> Update(CustomersRequest model, CancellationToken cancellationToken)
        {
            var customersRequest = await _db.CustomersRequests.FirstOrDefaultAsync(x => x.Id == model.Id, cancellationToken);
            if (customersRequest == null) { throw new Exception("درخواستی یافت نشد"); }

            if (customersRequest.Status == StatusEnum.non || customersRequest.Status == StatusEnum.waiting || customersRequest.Status == StatusEnum.choice)
            {
                if (model.Status == StatusEnum.progress)
                {
                    throw new Exception("شما مجاز به این تغیر نیستید");
                }
            }
            customersRequest.Status = model.Status;
            //customersRequest.DateWork = model.DateWork;
            //customersRequest.Description = model.Description;
            //customersRequest.Photo = model.Photo;

            await _db.SaveChangesAsync(cancellationToken);
            return customersRequest;

        }
    }
}
