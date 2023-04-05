using Volo.Abp.Modularity;

namespace STD;

[DependsOn(
    typeof(STDApplicationModule),
    typeof(STDDomainTestModule)
    )]
public class STDApplicationTestModule : AbpModule
{

}
