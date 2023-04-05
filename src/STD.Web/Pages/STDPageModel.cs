using STD.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace STD.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class STDPageModel : AbpPageModel
{
    protected STDPageModel()
    {
        LocalizationResourceType = typeof(STDResource);
    }
}
