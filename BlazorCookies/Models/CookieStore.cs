using System;

namespace BlazorCookies.Models;

public class CookieStore
{
    /// <summary>
    /// Unique identifier for the cookie store.
    /// </summary>
    public string Id { get; set; }

    /// <summary>
    /// Identifies all of the browser tabs that share this cookie store.
    /// </summary>
    public int[] TabIds { get; set; }

    /// <summary>
    /// True if the cookie is an icognito cookie store.
    /// </summary>
    public bool IsIcognito { get; set; }
}
