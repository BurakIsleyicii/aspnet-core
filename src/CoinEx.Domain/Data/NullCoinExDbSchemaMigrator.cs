using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace CoinEx.Data
{
    /* This is used if database provider does't define
     * ICoinExDbSchemaMigrator implementation.
     */
    public class NullCoinExDbSchemaMigrator : ICoinExDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}