using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomainCore.Base
{
    public interface IBaseDataService
    {
        public Task<string> UploadImage(IFormFile FormFile, string folderName, CancellationToken cancellation);
    }
}
