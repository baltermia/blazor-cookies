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
    public string? Value { get; set; }

    internal Cookie(string name, string? value = null)
    {
        Name = name;
        Value = value;
    }
}
