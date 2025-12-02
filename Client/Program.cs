//Jonas da Rosa Oliveira
//https://www.linkedin.com/in/jonas-da-rosa-oliveira

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Client;
using Shared.Interfaces;
using Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5167/") });
builder.Services.AddScoped<IProdutosService, ProdutosService>();

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddAntDesign();

await builder.Build().RunAsync();
