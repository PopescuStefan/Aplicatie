using AplicatieMedicala.Localization;
using Volo.Abp.Application.Services;

namespace AplicatieMedicala;

/* Inherit your application services from this class.
 */
public abstract class AplicatieMedicalaAppService : ApplicationService
{
    protected AplicatieMedicalaAppService()
    {
        LocalizationResource = typeof(AplicatieMedicalaResource);
    }
}
