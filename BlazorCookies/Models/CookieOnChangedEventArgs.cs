using BlazorCookies.Enums;
using BlazorCookies.Services;

namespace BlazorCookies.Models;

/// <summary>
/// Class representing EventArgs that are sent when a <see cref="ICookieService.OnChanged" /> event is fired
/// </summary>
public class CookieOnChangedEventArgs
{
    /// <summary>
    /// A boolean that is set to true if a cookie was removed, and false if not.
    /// </summary>
    public bool Removed { get; set; }

    /// <summary>
    /// A <see cref="Models.Cookie"/> object containing information about the cookie that was set or removed.
    /// </summary>
    public Cookie Cookie { get; set; }

    /// <summary>
    /// A <see cref="OnChangedCause"/> value representing the underlying reason behind the <see cref="Models.Cookie"/> objects change.
    /// </summary>
    public OnChangedCause Cause { get; set; }
}
