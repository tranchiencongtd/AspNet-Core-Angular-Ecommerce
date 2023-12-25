using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommerce.ProductCategories;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Admin.Catalog.ProductCategories;

public class ProductCategoriesAppService : CrudAppService<
    ProductCategory,
    ProductCategoryDto,
    Guid,
    PagedResultRequestDto,
    CreateUpdateProductCategoryDto,
    CreateUpdateProductCategoryDto>, IProductCategoriesAppService
{
    public ProductCategoriesAppService(IRepository<ProductCategory, Guid> repository) : base(repository)
    {
    }

    public Task<PagedResultDto<ProductCategoryInListDto>> GetListFilterAsync(BaseListFilterDto input)
    {
        throw new NotImplementedException();
    }

    public Task<List<ProductCategoryInListDto>> GetListAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task DeleteMultipleAsync(IEnumerable<Guid> ids)
    {
        throw new NotImplementedException();
    }
}