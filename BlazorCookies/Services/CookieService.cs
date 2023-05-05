using BlazorCookies.Models;
using BlazorCookies.Repositories;
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
    public CookieService(ICookieRepository repo)
        : base(repo, typeof(T).FullName)
    { }
}

/// <summary>
/// Non-Generic ICookieService implementation
/// </summary>
internal class CookieService : ICookieService
{
    private readonly ICookieRepository _repo;

    public string? DefaultCookiePath { get; init; }

    /// <summary>
    /// Creates a new non-generic CookieSerivce, given a default cookie-path
    /// </summary>
    public CookieService(ICookieRepository repo, string? defaultCookiePath)
    {
        DefaultCookiePath = defaultCookiePath;
        _repo = repo;
    }

    public Task<Cookie> this[string name] => GetAsync(name);

    public Task<Cookie> GetAsync(string name) => throw new NotImplementedException();

    public Task<IEnumerable<Cookie>> GetAllAsync() => throw new NotImplementedException();
    public Task<Cookie> SetAsync(string name, string value) => SetAsync(new CookieDetails(name), value);

    public Task<Cookie> SetAsync(CookieDetails details, string value) => throw new NotImplementedException();

    public Task<Cookie> RemoveAsync(string name) => RemoveAsync(new CookieDetails(name));

    public Task<Cookie> RemoveAsync(CookieDetails details) => throw new NotImplementedException();
}
