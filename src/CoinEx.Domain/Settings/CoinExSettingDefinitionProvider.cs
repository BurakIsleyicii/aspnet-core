using Volo.Abp.Settings;

namespace CoinEx.Settings
{
    public class CoinExSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(CoinExSettings.MySetting1));
        }
    }
}
