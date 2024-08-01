using Volo.Abp.Modularity;

namespace Library_1;

[DependsOn(
    typeof(Library_1ApplicationModule),
    typeof(Library_1DomainTestModule)
)]
public class Library_1ApplicationTestModule : AbpModule
{

}
