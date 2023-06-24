using Microsoft.Extensions.DependencyInjection;

namespace Akunich.Extensions.Time;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddSystemTimeProvider(this IServiceCollection collection) =>
        collection.AddSingleton<ITimeProvider, SystemTimeProvider>();
}