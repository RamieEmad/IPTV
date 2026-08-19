using Iptv.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

public class IptvDbContextFactory
    : IDesignTimeDbContextFactory<IptvDbContext>
{
    public IptvDbContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var connectionString =
            configuration.GetConnectionString("Default");

        var optionsBuilder =
            new DbContextOptionsBuilder<IptvDbContext>();

        optionsBuilder.UseSqlServer(connectionString);

        return new IptvDbContext(optionsBuilder.Options);
    }
}