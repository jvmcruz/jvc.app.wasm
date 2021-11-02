using jvc.app.wasm.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace jvc.app.wasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddScoped(sp => new HttpClient 
            {
                BaseAddress = new Uri("https://jvc-app-webapi.herokuapp.com")
            });

            builder.Services.AddScoped<IFinanceService, FinanceService>();

            await builder.Build().RunAsync();
        }
    }
}
