using Volo.Abp.Settings;

namespace AplicatieMedicala.Settings;

public class AplicatieMedicalaSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AplicatieMedicalaSettings.MySetting1));
    }
}
