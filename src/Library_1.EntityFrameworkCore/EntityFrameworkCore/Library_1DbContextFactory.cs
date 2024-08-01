using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Library_1.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class Library_1DbContextFactory : IDesignTimeDbContextFactory<Library_1DbContext>
{
    public Library_1DbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        Library_1EfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<Library_1DbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new Library_1DbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Library_1.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
