using Volo.Abp.Modularity;

namespace Library_1;

[DependsOn(
    typeof(Library_1DomainModule),
    typeof(Library_1TestBaseModule)
)]
public class Library_1DomainTestModule : AbpModule
{

}
