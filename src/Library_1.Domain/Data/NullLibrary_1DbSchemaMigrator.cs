using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Library_1.Data;

/* This is used if database provider does't define
 * ILibrary_1DbSchemaMigrator implementation.
 */
public class NullLibrary_1DbSchemaMigrator : ILibrary_1DbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
