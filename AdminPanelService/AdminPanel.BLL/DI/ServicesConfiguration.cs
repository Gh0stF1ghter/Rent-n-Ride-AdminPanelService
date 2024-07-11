using Mapster;
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
}
