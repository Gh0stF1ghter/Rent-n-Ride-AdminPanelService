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
        services.AddGrpcClient<CatalogGrpcService.CatalogService.CatalogServiceClient>(options => 
            options.Address = new Uri(configuration.GetConnectionString("CatalogServiceConnection"))
            );
        services.AddGrpcClient<ClientGrpcService.ClientService.ClientServiceClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("ClientServiceConnection"))
            );
        services.AddGrpcClient<RentGrpcService.RentService.RentServiceClient>(options =>
            options.Address = new Uri(configuration.GetConnectionString("RentServiceConnection"))
            );
    }
}
