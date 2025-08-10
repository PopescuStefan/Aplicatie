using Microsoft.Extensions.Localization;
using AplicatieMedicala.Localization;
using Microsoft.Extensions.Localization;
using AplicatieMedicala.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AplicatieMedicala.Blazor.Client;

[Dependency(ReplaceServices = true)]
public class AplicatieMedicalaBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AplicatieMedicalaResource> _localizer;

    public AplicatieMedicalaBrandingProvider(IStringLocalizer<AplicatieMedicalaResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
