using AdminPanel.BLL.DI;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;

services.AddApplicationDependencies();

services.AddControllers();
services.AddEndpointsApiExplorer();

services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

await app.RunAsync();