using Library_1.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Library_1.Blazor;

public abstract class Library_1ComponentBase : AbpComponentBase
{
    protected Library_1ComponentBase()
    {
        LocalizationResource = typeof(Library_1Resource);
    }
}
