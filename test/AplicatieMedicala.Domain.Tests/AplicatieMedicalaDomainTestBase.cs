using Volo.Abp.Modularity;

namespace AplicatieMedicala;

/* Inherit from this class for your domain layer tests. */
public abstract class AplicatieMedicalaDomainTestBase<TStartupModule> : AplicatieMedicalaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
