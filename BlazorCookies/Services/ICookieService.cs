using BlazorCookies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCookies.Services;

public interface ICookieService<T> : ICookieService { }

/// <summary>
/// Interface representing the Service which gets & sets cookies, and fires events when they change.
/// </summary>
public interface ICookieService
{
    /// <summary>
    /// The default Path/Url that is used when creating/setting <see cref="Cookie" /> objects and no path/url is given.
    /// <para>
    /// Used in <see cref="GetAsync" />, <see cref="SetAsync" />, <see cref="RemoveAsync" /> and <see cref="this[CookieDetails]" />
    /// </para>
    /// </summary>
    public string? DefaultCookiePath { get; }

    /// <summary>
    /// Retrieves a single <see cref="Cookie" />, given its name and URL.
    /// 
    /// <para>
    /// If more than one <see cref="Cookie" /> with the same name exists for a given URL, the one with the longest path will be returned. 
    /// For Cookies with the same path length, the Cookie with the earliest creation time will be returned. 
    /// If no matching Cookie could be found, the Value is null.
    /// </para>
    /// </summary>
    /// <param name="name">String representing the name of the cookie to retrieve.</param>
    public Task<Cookie> this[string name] { get; }

    /// <summary>
    /// Retrieves a single <see cref="Cookie" />, given its name and URL.
    /// 
    /// <para>
    /// If more than one <see cref="Cookie" /> with the same name exists for a given URL, the one with the longest path will be returned. 
    /// For Cookies with the same path length, the Cookie with the earliest creation time will be returned. 
    /// If no matching Cookie could be found, the Value is null.
    /// </para>
    /// </summary>
    /// <param name="name">String representing the name of the cookie to retrieve.</param>
    public Task<Cookie> GetAsync(string name);

    /// <summary>
    /// Gets all <see cref="Cookie" /> objects
    /// </summary>
    public Task<IEnumerable<Cookie>> GetAllAsync();

    /// <summary>
    /// Sets the underlying cookie matching the name
    /// </summary>
    /// <returns>The <see cref="Cookie"/> that was set</returns>
    public Task<Cookie> SetAsync(string name, string value);

    /// <summary>
    /// Sets the underlying cookie matching the <see cref="CookieDetails" />
    /// </summary>
    /// <returns>The <see cref="Cookie"/> that was set</returns>
    public Task<Cookie> SetAsync(CookieDetails details, string value);

    /// <summary>
    /// Deletes a cookie, given its <see cref="CookieDetails"/>.
    /// </summary>
    /// <param name="details"><see cref="CookieDetails" /> specifying the <see cref="Cookie"/> to be deleted.</param>
    /// <returns>The <see cref="Cookie"/> that was deleted</returns>
    public Task<Cookie> RemoveAsync(CookieDetails details);

    /// <summary>
    /// Deletes a cookie, given its name
    /// </summary>
    /// <returns>The <see cref="Cookie"/> that was deleted</returns>
    public Task<Cookie> RemoveAsync(string name);
}
