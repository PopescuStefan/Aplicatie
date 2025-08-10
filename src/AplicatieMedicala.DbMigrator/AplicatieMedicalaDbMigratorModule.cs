using AplicatieMedicala.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AplicatieMedicala.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AplicatieMedicalaEntityFrameworkCoreModule),
    typeof(AplicatieMedicalaApplicationContractsModule)
)]
public class AplicatieMedicalaDbMigratorModule : AbpModule
{
}
