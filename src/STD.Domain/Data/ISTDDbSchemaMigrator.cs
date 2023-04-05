using System.Threading.Tasks;

namespace STD.Data;

public interface ISTDDbSchemaMigrator
{
    Task MigrateAsync();
}
