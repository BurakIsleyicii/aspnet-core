using CoinEx.MongoDB;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace CoinEx.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(CoinExMongoDbModule),
        typeof(CoinExApplicationContractsModule)
        )]
    public class CoinExDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
