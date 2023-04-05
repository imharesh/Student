using System;
using System.Collections.Generic;
using System.Text;
using STD.Localization;
using Volo.Abp.Application.Services;

namespace STD;

/* Inherit your application services from this class.
 */
public abstract class STDAppService : ApplicationService
{
    protected STDAppService()
    {
        LocalizationResource = typeof(STDResource);
    }
}
