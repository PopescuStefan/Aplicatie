using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace AplicatieMedicala.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class AplicatieMedicalaDbContextFactory : IDesignTimeDbContextFactory<AplicatieMedicalaDbContext>
{
    public AplicatieMedicalaDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        AplicatieMedicalaEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<AplicatieMedicalaDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new AplicatieMedicalaDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../AplicatieMedicala.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
