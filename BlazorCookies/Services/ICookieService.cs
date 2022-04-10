using BlazorCookies.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorCookies.Services;

/// <summary>
/// Interface representing the Service which gets & sets cookies, and fires events when they change.
/// </summary>
public interface ICookieService
{
    /// <summary>
    /// Delegate representing a method that handles <see cref="OnChanged"/> events
    /// </summary>
    /// <param name="sender">Object that fired the event</param>
    /// <param name="e">EventArgs that contain data containing changed Cookies</param>
    public delegate void OnChangedEventHandler(object sender, CookieOnChangedEventArgs e);

    /// <summary>
    /// Event that is fired when a <see cref="Cookie"/> that can be accessed is set or removed.
    /// </summary>
    public event OnChangedEventHandler OnChanged;

    /// <summary>
    /// Retrieves a single <see cref="Cookie" />, given its name and URL.
    /// 
    /// <para>
    /// If more than one <see cref="Cookie" /> with the same name exists for a given URL, the one with the longest path will be returned. 
    /// For Cookies with the same path length, the Cookie with the earliest creation time will be returned. 
    /// If no matching Cookie could be found, null is returned.
    /// </para>
    /// </summary>
    /// <param name="url">String representing the URL with which the Cookie to retrieve is associated. This argument may be a full URL, in which case any data following the URL path (e.g. the query string) is ignored.</param>
    /// <param name="name">String representing the name of the cookie to retrieve.</param>
    /// <param name="storeId">String representing the ID of the cookie store in which to look for the cookie (as returned by <see cref="GetAllCookieStoresAsync"/>). By default, the current execution context's cookie store will be used.</param>
    /// <returns>A single <see cref="Cookie" />, given its name and URL.</returns>
    public Task<Cookie> GetAsync(string url, string name, string storeId = null);

    /// <summary>
    /// Retrieves a single <see cref="Cookie" />, given its <see cref="CookieDetails"/>.
    /// <para>
    /// If more than one <see cref="Cookie" /> with the same name exists for a given URL, the one with the longest path will be returned. 
    /// For Cookies with the same path length, the Cookie with the earliest creation time will be returned. 
    /// If no matching Cookie could be found, null is returned.
    /// </para>
    /// </summary>
    /// <param name="details"><see cref="CookieDetails"/> object containing details that can be used to match cookies to be retrieved.</param>
    /// <returns>A single <see cref="Cookie" />, given its <see cref="CookieDetails"/></returns>
    public Task<Cookie> GetAsync(CookieDetails details);

    /// <summary>
    /// Retrieves all <see cref="Cookie" /> objects from a single <see cref="CookieStore" /> that match the given information.
    /// </summary>
    /// <param name="store">The <see cref="CookieStore" /> that contains the <see cref="Cookie" /> objects to be returned</param>
    /// <returns>A list of <see cref="Cookie" /> objects that are in the given <see cref="CookieStore"/>. Only unexpired cookies are returned. The cookies returned will be sorted by path length, longest to shortest. If multiple cookies have the same path length, those with the earliest creation time will be first.</returns>
    public Task<IEnumerable<Cookie>> GetAllAsync(CookieStore store);

    /// <summary>
    /// Retrieves all <see cref="Cookie" /> objects from a single <see cref="CookieStore" /> that match the given (optional) information.
    /// </summary>
    /// <param name="details"><see cref="CookieDetails"/> object containing details that can be used to match cookies to be retrieved.</param>
    /// <returns>A list of <see cref="Cookie" /> objects that match the parameters. Only unexpired cookies are returned. The cookies returned will be sorted by path length, longest to shortest. If multiple cookies have the same path length, those with the earliest creation time will be first.</returns>
    public Task<IEnumerable<Cookie>> GetAllAsync(CookieDetails details);

    /// <summary>
    /// Returns a <see cref="IEnumerable{CookieStore}"/> list of all <see cref="CookieStore"/> objects.
    /// </summary>
    /// <returns>All accessible <see cref="CookieStore"/> objects</returns>
    public Task<IEnumerable<CookieStore>> GetAllCookieStoresAsync();
}
