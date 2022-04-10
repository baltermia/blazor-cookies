namespace BlazorCookies.Models;

/// <summary>
/// Class representing details used to get/set <see cref="Cookie"/> objects.
/// </summary>
public class CookieDetails
{
    /// <summary>
    /// String representing a domain that <see cref="Cookie" /> objects must be associated with (they can be associated either with this exact domain or one of its subdomains).
    /// </summary>
    public string Domain { get; set; }

    /// <summary>
    /// String representing a name that the <see cref="Cookie" /> objects should have.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// String representing a path — the <see cref="Cookie" /> objects' path must be identical to this one.
    /// </summary>
    public string Path { get; set; }

    /// <summary>
    /// Bool that filters <see cref="Cookie" /> objects by their secure property, allowing you to filter secure cookies vs. non-secure cookies.
    /// </summary>
    public bool? Secure { get; set; } = null;

    /// <summary>
    /// Bool that filters the <see cref="Cookie" /> objects by their session property, allowing you to filter session cookies vs. persistent cookies.
    /// </summary>
    public bool? Session { get; set; } = null;

    /// <summary>
    /// String representing the <see cref="CookieStore.Id" /> to retrieve <see cref="Cookie" /> objects from. If omitted, the current execution context's cookie store will be used.
    /// </summary>
    public string StoreId { get; set; }

    /// <summary>
    /// String representing a URL that the retrieved <see cref="Cookie" /> objects must be associated with.
    /// </summary>
    public string Url { get; set; }
}
