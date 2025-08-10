using System.Threading.Tasks;

namespace AplicatieMedicala.Data;

public interface IAplicatieMedicalaDbSchemaMigrator
{
    Task MigrateAsync();
}
