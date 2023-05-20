using Ecommerce.Admin;
using Volo.Abp.Modularity;

namespace Ecommerce;

[DependsOn(
    typeof(EcommerceAdminApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceApplicationTestModule : AbpModule
{

}
