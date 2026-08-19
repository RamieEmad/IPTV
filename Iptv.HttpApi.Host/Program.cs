using Iptv.HttpApi.Host;

namespace Iptv.HttpApi.Host;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        await builder.Services.AddApplicationAsync<IptvHttpApiHostModule>();

        var app = builder.Build();

        await app.InitializeApplicationAsync();

        await app.RunAsync();
    }
}