using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace CoinEx.MongoDB
{
    [DependsOn(
        typeof(CoinExTestBaseModule),
        typeof(CoinExMongoDbModule)
        )]
    public class CoinExMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            var stringArray = CoinExMongoDbFixture.ConnectionString.Split('?');
                        var connectionString = stringArray[0].EnsureEndsWith('/')  +
                                                   "Db_" +
                                               Guid.NewGuid().ToString("N") + "/?" + stringArray[1];

            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = connectionString;
            });
        }
    }
}
