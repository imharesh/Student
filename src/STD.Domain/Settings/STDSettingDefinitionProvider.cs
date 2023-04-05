using Volo.Abp.Settings;

namespace STD.Settings;

public class STDSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(STDSettings.MySetting1));
    }
}
