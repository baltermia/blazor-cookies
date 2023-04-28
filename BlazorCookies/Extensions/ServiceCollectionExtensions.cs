﻿using BlazorCookies.Services;
using Microsoft.Extensions.DependencyInjection;
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
        services.AddScoped<ICookieService, CookieService>(provider => 
                    new CookieService(provider.GetRequiredService<IJSRuntime>(), typeof(T).FullName))
                .AddGenericBlazorCookies();

    /// <summary>
    /// Add both non-generic and generic ICookieServices
    /// </summary>
    /// <param name="defaultCookiePath">The default cookie-path to all non-generic ICookieService-Cookies: <see cref="ICookieService.DefaultCookiePath"/></param>
    public static IServiceCollection AddBlazorCookies(this IServiceCollection services, string defaultCookiePath) =>
        services.AddScoped<ICookieService, CookieService>(provider => 
                    new CookieService(provider.GetRequiredService<IJSRuntime>(), defaultCookiePath))
                .AddGenericBlazorCookies();

    /// <summary>
    /// Add generic ICookieServices
    /// </summary>
    public static IServiceCollection AddGenericBlazorCookies(this IServiceCollection services) =>
        services.AddScoped(typeof(ICookieService<>), typeof(CookieService<>));
}
