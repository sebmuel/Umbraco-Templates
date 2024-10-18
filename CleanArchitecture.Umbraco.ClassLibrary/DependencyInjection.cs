using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Umbraco.ClassLibrary;

public static class DependencyInjection
{
    public static IServiceCollection AddLayer(this IServiceCollection services)
    {
        return services;
    }
}