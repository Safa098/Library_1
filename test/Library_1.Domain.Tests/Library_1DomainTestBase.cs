using Volo.Abp.Modularity;

namespace Library_1;

/* Inherit from this class for your domain layer tests. */
public abstract class Library_1DomainTestBase<TStartupModule> : Library_1TestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
