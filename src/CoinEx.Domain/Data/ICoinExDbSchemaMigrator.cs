using System.Threading.Tasks;

namespace CoinEx.Data
{
    public interface ICoinExDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
