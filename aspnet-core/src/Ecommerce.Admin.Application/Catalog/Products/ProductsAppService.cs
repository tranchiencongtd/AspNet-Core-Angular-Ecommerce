using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecommerce.Admin.Catalog.Products.Attributes;
using Ecommerce.ProductCategories;
using Ecommerce.Products;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Ecommerce.Admin.Catalog.Products
{
    public class ProductsAppService : CrudAppService<
        Product,
        ProductDto,
        Guid,
        PagedResultRequestDto,
        CreateUpdateProductDto,
        CreateUpdateProductDto>, IProductsAppService
    {
        public ProductsAppService(IRepository<Product, Guid> repository): base(repository)
        {
           
        }
        
        public async Task<PagedResultDto<ProductInListDto>> GetListFilterAsync(BaseListFilterDto input)
        {
            var query = await Repository.GetQueryableAsync();
            query = query.WhereIf(!string.IsNullOrWhiteSpace(input.Keyword), x => x.Name.Contains(input.Keyword));

            var totalCount = await AsyncExecuter.LongCountAsync(query);
            var data = await AsyncExecuter.ToListAsync(query.Skip(input.SkipCount).Take(input.MaxResultCount));

            return new PagedResultDto<ProductInListDto>(totalCount,ObjectMapper.Map<List<Product>,List<ProductInListDto>>(data));
        }

        public async Task<List<ProductInListDto>> GetListAllAsync()
        {
            var query = await Repository.GetQueryableAsync();
            query = query.Where(x=>x.IsActive == true);
            var data = await AsyncExecuter.ToListAsync(query);

            return ObjectMapper.Map<List<Product>, List<ProductInListDto>>(data);
        }

        public async Task DeleteMultipleAsync(IEnumerable<Guid> ids)
        {
            await Repository.DeleteManyAsync(ids);
            await UnitOfWorkManager.Current?.SaveChangesAsync()!;
        }


        public Task<PagedResultDto<ProductInListDto>> GetListFilterAsync(ProductListFilterDto input)
        {
            throw new NotImplementedException();
        }
        

        public Task<string> GetThumbnailImageAsync(string fileName)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetSuggestNewCodeAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductAttributeValueDto> AddProductAttributeAsync(AddUpdateProductAttributeDto input)
        {
            throw new NotImplementedException();
        }

        public Task<ProductAttributeValueDto> UpdateProductAttributeAsync(Guid id, AddUpdateProductAttributeDto input)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductAttributeAsync(Guid attributeId, Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductAttributeValueDto>> GetListProductAttributeAllAsync(Guid productId)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResultDto<ProductAttributeValueDto>> GetListProductAttributesAsync(ProductAttributeListFilterDto input)
        {
            throw new NotImplementedException();
        }
    }
}