using Iptv.EntityFrameworkCore;
using Iptv.EntityFrameworkCore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Volo.Abp;
using Volo.Abp.Autofac;


var application = await AbpApplicationFactory
    .CreateAsync<IptvEntityFrameworkCoreModule>();

await application.InitializeAsync();

var dbContext = application.ServiceProvider
    .GetRequiredService<IptvDbContext>();

await dbContext.Database.MigrateAsync();

Console.WriteLine("Database migration completed successfully.");