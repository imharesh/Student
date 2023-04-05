using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace STD.Data;

/* This is used if database provider does't define
 * ISTDDbSchemaMigrator implementation.
 */
public class NullSTDDbSchemaMigrator : ISTDDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
