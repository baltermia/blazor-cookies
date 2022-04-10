using BlazorCookies.Services;
using BlazorCookies.Models;

namespace BlazorCookies.Enums;

/// <summary>
/// Enum representing the underlying reason behind a <see cref="ICookieService.OnChanged"/> event fire.
/// </summary>
public enum OnChangedCause
{
    /// <summary>A <see cref="Cookie"/> has been automatically removed due to garbage collection.</summary>
    Evicted,

    /// <summary>A <see cref="Cookie"/> has been automatically removed due to expiry.</summary>
    Expired,

    /// <summary>A <see cref="Cookie"/> has been inserted or removed via an explicit call to <see cref="ICookieService.RemoveAsync"/>.</summary>
    Explicit,

    /// <summary>A <see cref="Cookie"/> has been overwritten by a cookie with an already-expired expiration date.</summary>
    Expired_Overwrite,

    /// <summary>A call to <see cref="ICookieService.SetAsync"/> overwrote this <see cref="Cookie"/> with a different one.</summary>
    Overwrite
}
