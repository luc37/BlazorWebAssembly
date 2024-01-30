using BlazorWebAssembly;
using BlazorWebAssembly.Services.Api.Implementations;
using BlazorWebAssembly.Services.Api.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

//IOC
builder.Services.AddTransient<IApiService, ApiService>();
builder.Services.AddTransient<IPokemonApiService, PokemonApiService>();

await builder.Build().RunAsync();
