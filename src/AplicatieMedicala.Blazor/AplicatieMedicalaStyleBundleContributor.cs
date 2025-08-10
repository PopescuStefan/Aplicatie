using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace AplicatieMedicala.Blazor;

public class AplicatieMedicalaStyleBundleContributor : BundleContributor
{
    public override void ConfigureBundle(BundleConfigurationContext context)
    {
        context.Files.Add(new BundleFile("main.css", true));
    }
}
