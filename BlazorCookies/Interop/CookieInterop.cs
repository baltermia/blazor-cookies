using Microsoft.JSInterop;

namespace BlazorCookies.Interop;

internal class CookieInterop
{
    private readonly IJSRuntime _jsRuntime;

    public CookieInterop(IJSRuntime jsRuntime) => _jsRuntime = jsRuntime;
}
