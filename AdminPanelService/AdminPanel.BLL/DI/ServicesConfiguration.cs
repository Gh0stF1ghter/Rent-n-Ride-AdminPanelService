using Mapster;
using MassTransit;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdminPanel.BLL.DI;
public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddMessageBroker(configuration);

        services.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }

    public static void AddMessageBroker(this IServiceCollection services, IConfiguration configuration) =>
        services.AddMassTransit(cfg =>
        {
            cfg.SetKebabCaseEndpointNameFormatter();

            cfg.UsingRabbitMq((context, factoryCfg) =>
            {
                factoryCfg.Host(configuration.GetConnectionString("RabbitMQ"));
            });
        });
}
