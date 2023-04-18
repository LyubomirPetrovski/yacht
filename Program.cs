using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Yacht.Providers.Sailogy;

var hostBuilder = CreateHostBuilder(args);
//var host = hostBuilder.Build();
var host = await hostBuilder.StartAsync();

var sailogy = new SailogyLastMinute(host.Services.GetRequiredService<IHttpClientFactory>());
await sailogy.Scrape();

IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((_, services) =>
        {
            services.AddHttpClient();
        }).UseConsoleLifetime();

