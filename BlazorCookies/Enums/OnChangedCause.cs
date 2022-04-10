using BlazorCookies.Services;

namespace BlazorCookies.Enums;

/// <summary>
/// Enum representing the underlying reason behind a <see cref="ICookieService.OnChanged"/> event fire.
/// </summary>
public enum OnChangedCause
{
    Evicted,
    Expired,
    Explicit,
    Expired_Overwrite,
    Overwrite
}
