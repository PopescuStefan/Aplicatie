using AplicatieMedicala.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AplicatieMedicala.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AplicatieMedicalaController : AbpControllerBase
{
    protected AplicatieMedicalaController()
    {
        LocalizationResource = typeof(AplicatieMedicalaResource);
    }
}
