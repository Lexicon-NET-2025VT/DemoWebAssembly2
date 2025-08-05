using DemoWebAssembly2.Client.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace DemoWebAssembly2.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);

            builder.Services.AddSingleton<IGlobalStateCounter, GlobalStateCounter>();

            await builder.Build().RunAsync();
        }
    }
}
