using Volo.Abp.Modularity;

namespace AplicatieMedicala;

[DependsOn(
    typeof(AplicatieMedicalaDomainModule),
    typeof(AplicatieMedicalaTestBaseModule)
)]
public class AplicatieMedicalaDomainTestModule : AbpModule
{

}
