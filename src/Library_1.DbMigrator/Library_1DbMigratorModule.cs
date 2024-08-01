using Library_1.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace Library_1.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(Library_1EntityFrameworkCoreModule),
    typeof(Library_1ApplicationContractsModule)
)]
public class Library_1DbMigratorModule : AbpModule
{
}
