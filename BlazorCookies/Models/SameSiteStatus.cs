namespace BlazorCookies.Models;

public enum SameSiteStatus
{
    /// <summary>Represents a <see cref="Cookie"/> set without a <see cref="Cookie.SameSite"/> attribute.</summary>
    NoRestriction,

    /// <summary>Corresponds to <code>SameSite=Lax</code></summary>
    Lax,

    /// <summary>Corresponds to <code>SameSite=Strict</code></summary>
    Strict
}
