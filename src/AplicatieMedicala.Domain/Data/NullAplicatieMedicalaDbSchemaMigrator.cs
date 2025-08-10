using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AplicatieMedicala.Data;

/* This is used if database provider does't define
 * IAplicatieMedicalaDbSchemaMigrator implementation.
 */
public class NullAplicatieMedicalaDbSchemaMigrator : IAplicatieMedicalaDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
