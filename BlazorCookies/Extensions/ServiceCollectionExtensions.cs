using BlazorCookies.Services;
using Microsoft.Extensions.DependencyInjection;

namespace BlazorCookies;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddBlazorCookies(this IServiceCollection services) =>
        services.AddScoped<ICookieService, CookieService>();
}
