﻿using AppDomainCore.Experts.DTO;
using AppDomainCore.Experts.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Experts.Contract.AppService
{
    public interface IExpertAppService
    {
        public Task<Expert> Get(int id, CancellationToken cancellationToken);
        public Task<List<Expert>> GetAll(CancellationToken cancellationToken);
        public Task<Expert> Add(ExpertAddDto expert, CancellationToken cancellationToken);
        public Task<Expert> Update(ExpertAddDto expert, CancellationToken cancellationToken);
        public Task<bool> Delete(int id, CancellationToken cancellationToken);
        public Task<ExpertUpdateProfileDto> GetUpdate(int id, CancellationToken cancellationToken);
        public Task<Expert> UpdateProfile(ExpertUpdateProfileDto expert, CancellationToken cancellationToken);
    }
}
