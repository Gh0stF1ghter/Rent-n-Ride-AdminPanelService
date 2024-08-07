using Microsoft.AspNetCore.Authentication.JwtBearer;
using Ocelot.DependencyInjection;

namespace Ocelot.WebHost.DI;

public static class ServicesConfiguration
{
    public static void ConfigureOcelot(this IServiceCollection services, IConfigurationManager configuration, IWebHostEnvironment environment)
    {
        configuration
            .AddJsonFile("ocelot.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"ocelot.{environment.EnvironmentName}.json", optional: true, reloadOnChange: true);

        services.AddOcelot(configuration);

        services.ConfigureCors(configuration);
    }

    private static void ConfigureCors(this IServiceCollection services, IConfiguration configuration)
    {
        var client = configuration.GetConnectionString("Client");

        services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
                builder
                .WithOrigins(client)
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials());
        });
    }

    public static void AddAuth0Authentication(this IServiceCollection services, IConfiguration configuration) =>
        services.AddAuthentication(
            options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer("Auth0Key",
                options =>
                {
                    options.Authority = $"https://{configuration["Auth0:Domain"]}/";
                    options.Audience = configuration["Auth0:Audience"];
                });
}