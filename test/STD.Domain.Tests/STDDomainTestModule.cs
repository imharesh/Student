using STD.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace STD;

[DependsOn(
    typeof(STDEntityFrameworkCoreTestModule)
    )]
public class STDDomainTestModule : AbpModule
{

}
