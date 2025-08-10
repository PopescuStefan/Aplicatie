using AplicatieMedicala.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AplicatieMedicala.Blazor.Client;

public abstract class AplicatieMedicalaComponentBase : AbpComponentBase
{
    protected AplicatieMedicalaComponentBase()
    {
        LocalizationResource = typeof(AplicatieMedicalaResource);
    }
}
