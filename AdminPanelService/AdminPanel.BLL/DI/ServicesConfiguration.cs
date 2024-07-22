using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdminPanel.BLL.DI;
public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services, IConfiguration configuration)
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

        services.ConfigureGrpcToServices(configuration);
    }

    public static void ConfigureGrpcToServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddGrpcClient<CatalogGrpcService.CatalogService.CatalogServiceClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("CatalogServiceConnection"))
            ).ConfigurePrimaryHttpMessageHandler(() =>
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                return handler;
            });

        services.AddGrpcClient<ClientGrpcService.ClientService.ClientServiceClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("ClientServiceConnection"))
            ).ConfigurePrimaryHttpMessageHandler(() =>
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                return handler;
            });

        services.AddGrpcClient<RentGrpcService.RentService.RentServiceClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("RentServiceConnection"))
            ).ConfigurePrimaryHttpMessageHandler(() =>
            {
                var handler = new HttpClientHandler
                {
                    ServerCertificateCustomValidationCallback = HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
                };

                return handler;
            });
    }
}
