using CoinEx.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace CoinEx.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class CoinExController : AbpController
    {
        protected CoinExController()
        {
            LocalizationResource = typeof(CoinExResource);
        }
    }
}