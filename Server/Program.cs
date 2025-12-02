//Jonas da Rosa Oliveira
//https://www.linkedin.com/in/jonas-da-rosa-oliveira

using Server.Services;
using Shared.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProdutosService, ProdutosService>();

builder.Services.AddHttpClient();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();
app.MapControllers();
app.MapFallbackToFile("index.html");
app.Run();