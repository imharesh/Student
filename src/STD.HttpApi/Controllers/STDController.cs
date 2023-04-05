using STD.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace STD.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class STDController : AbpControllerBase
{
    protected STDController()
    {
        LocalizationResource = typeof(STDResource);
    }
}
