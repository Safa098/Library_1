using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Library_1.Blazor;

[Dependency(ReplaceServices = true)]
public class Library_1BrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "Library_1";
}
