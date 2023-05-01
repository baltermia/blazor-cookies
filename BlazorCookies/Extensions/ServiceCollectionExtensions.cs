using BlazorCookies.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.JSInterop;

namespace BlazorCookies;

/// <summary>
/// Extension Methods for IServiceCollection that add BlazorCookie-Services
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add both non-generic and generic ICookieServices
    /// </summary>
    /// <typeparam name="T">The Assembly-Fullname is used as <see cref="ICookieService.DefaultCookiePath"/></typeparam>
    public static IServiceCollection AddBlazorCookies<T>(this IServiceCollection services) =>
        services.AddBlazorCookies(typeof(T).FullName)
                .AddGenericBlazorCookies();

    /// <summary>
    /// Add both non-generic and generic ICookieServices
    /// </summary>
    /// <param name="defaultCookiePath">The default cookie-path to all non-generic ICookieService-Cookies: <see cref="ICookieService.DefaultCookiePath"/></param>
    public static IServiceCollection AddBlazorCookies(this IServiceCollection services, string defaultCookiePath)
    {
        services.TryAddTransient<ICookieService>(provider =>
                    new CookieService(provider.GetRequiredService<IJSRuntime>(), defaultCookiePath));
        
        return services.AddGenericBlazorCookies();
    }

    /// <summary>
    /// Add generic ICookieServices
    /// </summary>
    public static IServiceCollection AddGenericBlazorCookies(this IServiceCollection services)
    {
        services.TryAddScoped(typeof(ICookieService<>), typeof(CookieService<>));
        return services;
    }
}
