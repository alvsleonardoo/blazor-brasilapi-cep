using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using BlazorWasmBrasilApiCep;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Registra o HttpClient configurado para a BrasilAPI
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://brasilapi.com.br/")
});

await builder.Build().RunAsync();