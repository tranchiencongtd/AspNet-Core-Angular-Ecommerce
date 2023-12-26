using AutoMapper;
using Ecommerce.Admin.Catalog.ProductCategories;
using Ecommerce.ProductCategories;

namespace Ecommerce.Admin;

public class EcommerceApplicationAutoMapperProfile : Profile
{
    public EcommerceApplicationAutoMapperProfile()
    {
        //Product Category
        CreateMap<ProductCategory, ProductCategoryDto>();
        CreateMap<ProductCategory, ProductCategoryInListDto>();
        CreateMap<CreateUpdateProductCategoryDto, ProductCategory>();
    }
}
