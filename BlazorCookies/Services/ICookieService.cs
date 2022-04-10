using BlazorCookies.Models;
using System.Collections.Generic;

namespace BlazorCookies.Services;

/// <summary>
/// Interface representing the Service which gets & sets cookies, and fires events when they change.
/// </summary>
public interface ICookieService
{
    /// <summary>
    /// Retrieves a single <see cref="CookieStore" />, given its name and URL.
    /// 
    /// If more than one <see cref="Cookie" /> with the same name exists for a given URL, the one with the longest path will be returned. 
    /// For Cookies with the same path length, the Cookie with the earliest creation time will be returned. 
    /// If no matching Cookie could be found, null is returned.
    /// </summary>
    /// <param name="url">String representing the URL with which the Cookie to retrieve is associated. This argument may be a full URL, in which case any data following the URL path (e.g. the query string) is ignored.</param>
    /// <param name="name">String representing the name of the cookie to retrieve.</param>
    /// <param name="storeId">String representing the ID of the cookie store in which to look for the cookie (as returned by cookies.getAllCookieStores()). By default, the current execution context's cookie store will be used.</param>
    /// <returns>A single <see cref="Cookie" />, given its name and URL.</returns>
    public Cookie Get(string url, string name, string storeId = null);

    /// <summary>
    /// Retrieves all <see cref="Cookie" /> objects from a single <see cref="CookieStore" /> that match the given information.
    /// </summary>
    /// <param name="store">The <see cref="CookieStore" /> that contains the <see cref="Cookie" /> objects to be returned</param>
    /// <returns>A list of <see cref="Cookie" /> objects that are in the given <see cref="CookieStore"/>. Only unexpired cookies are returned. The cookies returned will be sorted by path length, longest to shortest. If multiple cookies have the same path length, those with the earliest creation time will be first.</returns>
    public IEnumerable<Cookie> GetAll(CookieStore store);
}
