using Ecommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Modularity;
using Volo.Abp.Caching.StackExchangeRedis;
namespace Ecommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    // typeof(AbpCachingStackExchangeRedisModule),
    typeof(EcommerceEntityFrameworkCoreModule),
    typeof(EcommerceApplicationContractsModule)
    )]
public class EcommerceDbMigratorModule : AbpModule
{
    // public override void ConfigureServices(ServiceConfigurationContext context)
    // {
    //     Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "Ecommerce:"; });
    // }
}
