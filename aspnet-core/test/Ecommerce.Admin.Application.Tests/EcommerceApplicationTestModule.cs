using Volo.Abp.Modularity;

namespace Ecommerce.Admin;

[DependsOn(
    typeof(EcommerceAdminApplicationModule),
    typeof(EcommerceDomainTestModule)
    )]
public class EcommerceApplicationTestModule : AbpModule
{

}
