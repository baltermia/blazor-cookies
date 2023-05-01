using BlazorCookies.Repositories;
using Microsoft.JSInterop;

namespace BlazorCookies.Interop;

internal class CookieInteropRepository : ICookieRepository
{
    private readonly IJSRuntime _jsRuntime;

    public CookieInteropRepository(IJSRuntime jsRuntime) => _jsRuntime = jsRuntime;
}
