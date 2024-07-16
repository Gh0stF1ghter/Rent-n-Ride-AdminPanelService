using FluentValidation;
using SharpGrip.FluentValidation.AutoValidation.Mvc.Extensions;
using System.Reflection;
using User.API.Extensions;

namespace AdminPanel.API.DI;

public static class ServicesConfiguration
{
    public static void AddApiDependencies(this IServiceCollection services)
    {
        services.AddAutoValidation();

        services.ConfigureSwagger();
    }

    public static void AddAutoValidation(this IServiceCollection services)
    {
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
        services.AddFluentValidationAutoValidation();
    }
}
