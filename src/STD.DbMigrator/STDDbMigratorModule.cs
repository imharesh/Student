using STD.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace STD.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(STDEntityFrameworkCoreModule),
    typeof(STDApplicationContractsModule)
    )]
public class STDDbMigratorModule : AbpModule
{

}
