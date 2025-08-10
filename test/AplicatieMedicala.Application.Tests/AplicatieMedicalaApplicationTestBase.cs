using Volo.Abp.Modularity;

namespace AplicatieMedicala;

public abstract class AplicatieMedicalaApplicationTestBase<TStartupModule> : AplicatieMedicalaTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
