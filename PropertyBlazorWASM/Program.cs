using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PropertyBlazorWASM;
using PropertyBlazorWASM.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");

// Configure HttpClient for your API
//step 1: add using System.Net.Http;
builder.Services.AddScoped(sp =>
    new HttpClient { BaseAddress = new Uri("https://localhost:7239/") });

//step 2: add using PropertyBlazorWASM.Services;
builder.Services.AddScoped<PropertyService>();

await builder.Build().RunAsync();

