using System;

namespace BlazorCookies.Models;

/// <summary>
/// Class representing details used to set & delete <see cref="Cookie"/> objects.
/// </summary>
public class CookieDetails
{
    /// <summary>
    /// The name of the cookie.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// The domain of the cookie (e.g. "www.google.com" "example.com").
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// The path of the cookie.
    /// </summary>
    public string? Path { get; set; }

    /// <summary>
    /// Indicates the SameSite state of the cookie.
    /// </summary>
    public SameSiteStatus SameSite { get; set; }

    /// <summary>
    /// The expiration date of the cookie. Not provided for session cookies.
    /// </summary>
    public DateTime? Expiration { get; set; }
    /// <summary>
    /// Bool that filters <see cref="Cookie" /> objects by their secure property, allowing you to filter secure cookies vs. non-secure cookies.
    /// </summary>
    public bool Secure { get; set; } = false;

    public CookieDetails(string name) => Name = name;
}
