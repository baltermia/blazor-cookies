using BlazorCookies.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCookies.Services;

internal class CookieService : ICookieService
{
    public Cookie this[CookieDetails details] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public Cookie this[string name, string url = null, string storeId = null] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string DefaultCookiePath { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

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
