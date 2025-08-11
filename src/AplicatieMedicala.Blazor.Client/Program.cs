using System.Threading.Tasks;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace AplicatieMedicala.Blazor.Client;

public class Program
{
    public async static Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        // Adaugă appsettings.json la configurare explicit (opțional, deja inclus)
        builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

        // Configurează autentificarea OIDC folosind setările din appsettings.json
        builder.Services.AddOidcAuthentication(options =>
        {
            builder.Configuration.Bind("AuthServer", options.ProviderOptions);
        });

        var application = await builder.AddApplicationAsync<AplicatieMedicalaBlazorClientModule>(options =>
        {
            options.UseAutofac();
        });

        var host = builder.Build();

        await application.InitializeApplicationAsync(host.Services);

        await host.RunAsync();
    }
}
