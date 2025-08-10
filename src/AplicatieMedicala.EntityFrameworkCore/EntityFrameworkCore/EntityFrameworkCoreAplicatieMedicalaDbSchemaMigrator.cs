using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AplicatieMedicala.Data;
using Volo.Abp.DependencyInjection;

namespace AplicatieMedicala.EntityFrameworkCore;

public class EntityFrameworkCoreAplicatieMedicalaDbSchemaMigrator
    : IAplicatieMedicalaDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAplicatieMedicalaDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AplicatieMedicalaDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AplicatieMedicalaDbContext>()
            .Database
            .MigrateAsync();
    }
}
