using CoinEx.MongoDB;
using Volo.Abp.Modularity;

namespace CoinEx
{
    [DependsOn(
        typeof(CoinExMongoDbTestModule)
        )]
    public class CoinExDomainTestModule : AbpModule
    {

    }
}