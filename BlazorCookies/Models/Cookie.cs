using System;
using BlazorCookies.Enums;

namespace BlazorCookies.Models;

/// <summary>
/// Class representing browser cookie
/// </summary>
public class Cookie
{
    /// <summary>
    /// The name of the cookie.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The value of the cookie.
    /// </summary>
    public string Value { get; set; }

    /// <summary>
    /// The domain of the cookie (e.g. "www.google.com" "example.com").
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// True if the cookie is a host-only cookie (i.e. a request’s host must exactly match the domain of the cookie).
    /// </summary>
    public bool IsHostOnly { get; set; }

    /// <summary>
    /// The path of the cookie.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// True if the cookie is marked as Secure (i.e. its scope is limited to secure channels, typically HTTPS).
    /// </summary>
    public bool IsSecure { get; set; }

    /// <summary>
    /// True if the cookie is marked as HttpOnly (i.e. the cookie is inaccessible to client-side scripts).
    /// </summary>
    public bool IsHttpOnly { get; set; }

    /// <summary>
    /// True if the cookie is a session cookie, or false if it is a persistent cookie with an expiration date.
    /// </summary>
    public bool IsSession { get; set; }

    /// <summary>
    /// Indicates the SameSite state of the cookie.
    /// </summary>
    public SameSiteStatus SameSite { get; set; }

    /// <summary>
    /// The expiration date of the cookie. Not provided for session cookies.
    /// </summary>
    public DateTime? Expiration { get; set; }

    /// <summary>
    /// The ID of the cookie store containing this cookie.
    /// </summary>
    public string StoreId { get; set; }
}
