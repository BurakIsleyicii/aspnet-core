using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace CoinEx
{
    [Dependency(ReplaceServices = true)]
    public class CoinExBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "CoinEx";
    }
}
