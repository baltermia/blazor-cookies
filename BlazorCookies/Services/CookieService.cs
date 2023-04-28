using BlazorCookies.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCookies.Services;

/// <summary>
/// Generic ICookieService implementation
/// </summary>
internal class CookieService<T> : CookieService, ICookieService<T>
{
    /// <summary>
    /// Creates a new generic CookieService. The type-argument <see cref="CookieService{T}">T</see> is used to determine the <see cref="CookieService.DefaultCookiePath"/>
    /// </summary>
    public CookieService(IJSRuntime jsRuntime)
        : base(jsRuntime, typeof(T).FullName)
    { }
}

/// <summary>
/// Non-Generic ICookieService implementation
/// </summary>
internal class CookieService : ICookieService
{
    public string DefaultCookiePath { init; get; }

    /// <summary>
    /// Creates a new non-generic CookieSerivce, given a default cookie-path
    /// </summary>
    public CookieService(IJSRuntime jsRuntime, string defaultCookiePath)
    {
        DefaultCookiePath = defaultCookiePath;
        // IJSRuntime will be passed further down to use JS-Interop
    }

    public Cookie this[CookieDetails details] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Cookie this[string name, string url = null, string storeId = null] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public event ICookieService.OnChangedEventHandler OnChanged;

    public Task<IEnumerable<Cookie>> GetAllAsync(CookieStore store)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<Cookie>> GetAllAsync(CookieDetails details)
    {
        throw new NotImplementedException();
    }

    public Task<IEnumerable<CookieStore>> GetAllCookieStoresAsync()
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> GetAsync(string name, string url = null, string storeId = null)
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> GetAsync(CookieDetails details)
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> RemoveAsync(Cookie cookie)
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> RemoveAsync(CookieDetails details)
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> SetAsync(Cookie cookie)
    {
        throw new NotImplementedException();
    }

    public Task<Cookie> SetAsync(CookieDetails details, string value = null)
    {
        throw new NotImplementedException();
    }
}
