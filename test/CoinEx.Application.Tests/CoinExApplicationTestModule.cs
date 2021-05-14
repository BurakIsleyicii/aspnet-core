using Volo.Abp.Modularity;

namespace CoinEx
{
    [DependsOn(
        typeof(CoinExApplicationModule),
        typeof(CoinExDomainTestModule)
        )]
    public class CoinExApplicationTestModule : AbpModule
    {

    }
}