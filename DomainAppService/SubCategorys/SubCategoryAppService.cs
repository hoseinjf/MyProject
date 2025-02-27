using AppDomainCore.Base;
using AppDomainCore.Categorys.Entity;
using AppDomainCore.SubCategorys.Contract.AppService;
using AppDomainCore.SubCategorys.Contract.Service;
using AppDomainCore.SubCategorys.DTO;
using AppDomainCore.SubCategorys.Entity;
using AppDomainCore.Works.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainAppService.SubCategorys
{
    public class SubCategoryAppService : ISubCategoryAppService
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly IBaseDataService _bas;

        public SubCategoryAppService(ISubCategoryService subCategoryService, IBaseDataService baseData)
        {
            _subCategoryService = subCategoryService;
            _bas = baseData;
        }
        public async Task<SubCategory> Add(SubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            subCategory.Photo = new AppDomainCore.Photos.Entity.Photo()
            {
                Src = await _bas.UploadImage(subCategory.Pic, "subCategory", cancellationToken),
            };
            return await _subCategoryService.Add(subCategory, cancellationToken);
        }

        public async Task<bool> Delete(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Delete(id, cancellationToken);
        }

        public async Task<SubCategory> Get(int id, CancellationToken cancellationToken)
        {
            return await _subCategoryService.Get(id, cancellationToken);
        }

        public async Task<List<SubCategory>> GetAll(CancellationToken cancellationToken)
        {
            return await _subCategoryService.GetAll(cancellationToken);
        }

        public async Task<SubCategory> Update(SubCategoryDto subCategory, CancellationToken cancellationToken)
        {
            if (subCategory.Pic != null)
            {
                subCategory.Photo = new AppDomainCore.Photos.Entity.Photo()
                {
                    Src = await _bas.UploadImage(subCategory.Pic, "work", cancellationToken),
                };
            }
            return await _subCategoryService.Update(subCategory, cancellationToken);
        }
    }
}
