﻿using AppDataRepository.Db.Context;
using AppDomainCore.Customers.DTO;
using AppDomainCore.Customers.Entity;
using AppDomainCore.Experts.Contract.Repository;
using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using AppDomainCore.Users.Entity;
using AppDomainCore.Works.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDataRepository.Experts
{
    public class ExpertRepository : IExpertRepository
    {
        private readonly AppDbContext _db;

        public ExpertRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }

        public async Task<Expert> Add(ExpertAddDto expert, CancellationToken cancellationToken)
        {
            Expert expert1 = new Expert();
            expert1.User = new User()
            {
                FirstName = expert.FirstName,
                LastName = expert.LastName,
                Email = expert.Email,
                Address = expert.Address,
                UserName = expert.UserName,
                PasswordHash = expert.Password,
                NormalizedEmail = expert.Email,
                NormalizedUserName = expert.UserName,
                Phone = expert.Phone,
                Photo = expert.Photo,
                ProvinceId = expert.CityId

            };
            //expert1.Works = new List<Work>();

            expert1.Biography = expert.Biography;
            
            await _db.Experts.AddAsync(expert1, cancellationToken);
            await _db.SaveChangesAsync(cancellationToken);
            return expert1;
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            var expert = await _db.Experts.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (expert == null) { return false; }
            var userId = expert.UserId;
            var user = await _db.Users.FirstOrDefaultAsync(x => x.Id == userId);

            if (user.IsDelete == false)
            {
                user.IsDelete = true;
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            return false;
        }

        public async Task<Expert> Get(int id, CancellationToken cancellationToken)
        {
            var expert = await _db.Experts.Include(x => x.User).Include(x=>x.Works).Where(x => x.User.IsDelete == false).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (expert == null) { throw new Exception("کاربر یافت نشد"); }
            return expert;
        }

        public async Task<List<Expert>> GetAll(CancellationToken cancellationToken)
        {
            return await _db.Experts.Include(x => x.User.Photo).Include(x => x.User.Province).Include(x => x.Works).Where(x => x.User.IsDelete == false).ToListAsync(cancellationToken);
        }

        public async Task<Expert> Update(Expert expert, CancellationToken cancellationToken)
        {
            var expert1 = await _db.Experts.Include(x => x.User).FirstOrDefaultAsync(x => x.Id == expert.Id, cancellationToken);
            if (expert1 == null) { throw new Exception("کامنت یافت نشد"); }


            expert1.User = new User()
            {
                FirstName = expert.User.FirstName,
                LastName = expert.User.LastName,
                Email = expert.User.Email,
                Address = expert.User.Address,
                UserName = expert.User.UserName,
                PasswordHash = expert.User.PasswordHash,
                NormalizedEmail = expert.User.Email,
                NormalizedUserName = expert.User.UserName,
                Phone = expert.User.Phone,
                Photo = expert.User.Photo,
                ProvinceId = expert.User.ProvinceId
            };
            //expert1.Works = new List<Work>();

            await _db.SaveChangesAsync(cancellationToken);
            return expert1;
        }


    }
}
