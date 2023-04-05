using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace STD.Web;

[Dependency(ReplaceServices = true)]
public class STDBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "STD";
}
