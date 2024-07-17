using Mapster;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdminPanel.BLL.DI;
public static class ServicesConfiguration
{
    public static void AddApplicationDependencies(this IServiceCollection services)
    {
        TypeAdapterConfig.GlobalSettings.Scan(Assembly.GetExecutingAssembly());

        services.AddMediatR(_ => _.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
    }

    public static void ConfigureGrpcToServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddGrpcClient<CatalogGrpcService.CatalogService.CatalogServiceClient>();
        services.AddGrpcClient<ClientGrpcService.ClientService.ClientServiceClient>();
        services.AddGrpcClient<RentGrpcService.RentService.RentServiceClient>();
    }
}
