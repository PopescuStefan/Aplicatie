using Volo.Abp.Modularity;

namespace AplicatieMedicala;

[DependsOn(
    typeof(AplicatieMedicalaApplicationModule),
    typeof(AplicatieMedicalaDomainTestModule)
)]
public class AplicatieMedicalaApplicationTestModule : AbpModule
{

}
