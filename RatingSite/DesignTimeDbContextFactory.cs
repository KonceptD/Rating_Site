using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using RatingSite;
using System;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<RatingSiteDbContext>
{
    public RatingSiteDbContext CreateDbContext(string[] args)
    {
        IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<RatingSiteDbContext>();
        var connectionString = configuration.GetConnectionString("RatingSiteDB");

        builder.UseSqlServer(connectionString);

        return new RatingSiteDbContext(builder.Options);
    }
}
