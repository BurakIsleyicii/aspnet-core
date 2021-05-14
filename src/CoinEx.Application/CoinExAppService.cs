using System;
using System.Collections.Generic;
using System.Text;
using CoinEx.Localization;
using Volo.Abp.Application.Services;

namespace CoinEx
{
    /* Inherit your application services from this class.
     */
    public abstract class CoinExAppService : ApplicationService
    {
        protected CoinExAppService()
        {
            LocalizationResource = typeof(CoinExResource);
        }
    }
}
