using CoinEx.MongoDB;
using Xunit;

namespace CoinEx
{
    [CollectionDefinition(CoinExTestConsts.CollectionDefinitionName)]
    public class CoinExDomainCollection : CoinExMongoDbCollectionFixtureBase
    {

    }
}
