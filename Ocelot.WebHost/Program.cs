using Ocelot.Middleware;
using Ocelot.WebHost.DI;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.ConfigureOcelot(builder.Configuration, builder.Environment);

services.AddAuth0Authentication(builder.Configuration);

services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddSwaggerForOcelot(builder.Configuration);

var app = builder.Build();

app.UseSwaggerForOcelotUI();

app.UseAuthentication();
app.UseAuthorization();

app.UseOcelot().Wait();

await app.RunAsync();