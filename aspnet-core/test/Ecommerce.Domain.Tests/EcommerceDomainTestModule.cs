using Ecommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Ecommerce;

[DependsOn(
    typeof(EcommerceEntityFrameworkCoreTestModule)
    )]
public class EcommerceDomainTestModule : AbpModule
{

}
