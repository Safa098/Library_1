using Volo.Abp.Settings;

namespace Library_1.Settings;

public class Library_1SettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(Library_1Settings.MySetting1));
    }
}
