using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Library_1.Data;
using Volo.Abp.DependencyInjection;

namespace Library_1.EntityFrameworkCore;

public class EntityFrameworkCoreLibrary_1DbSchemaMigrator
    : ILibrary_1DbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreLibrary_1DbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the Library_1DbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<Library_1DbContext>()
            .Database
            .MigrateAsync();
    }
}
