using AdminPanel.API.DI;
using AdminPanel.API.Extensions;
using AdminPanel.BLL.DI;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApplicationDependencies(builder.Configuration);
services.AddApiDependencies(builder.Configuration);

services.AddControllers();
services.AddEndpointsApiExplorer();

services.AddSwaggerGen();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();