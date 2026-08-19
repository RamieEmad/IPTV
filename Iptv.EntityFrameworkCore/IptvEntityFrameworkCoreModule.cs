using Iptv.Domain;
using Iptv.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Iptv.EntityFrameworkCore;

[DependsOn(
    typeof(IptvDomainModule),
    typeof(AbpEntityFrameworkCoreModule)
)]
public class IptvEntityFrameworkCoreModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddAbpDbContext<IptvDbContext>();

        Configure<AbpDbContextOptions>(options =>
        {
            options.Configure<IptvDbContext>(dbContextOptions =>
            {
                dbContextOptions.DbContextOptions
                .UseSqlServer(dbContextOptions.ConnectionString);
            });
        });
    }
}