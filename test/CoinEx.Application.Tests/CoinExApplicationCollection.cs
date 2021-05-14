using CoinEx.MongoDB;
using Xunit;

namespace CoinEx
{
    [CollectionDefinition(CoinExTestConsts.CollectionDefinitionName)]
    public class CoinExApplicationCollection : CoinExMongoDbCollectionFixtureBase
    {

    }
}
