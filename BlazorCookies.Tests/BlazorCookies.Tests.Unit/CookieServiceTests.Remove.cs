using BlazorCookies.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BlazorCookies.Tests.Unit;

public partial class CookieServiceTests
{
    [Test]
    public async Task Remove_NameOnly_Details()
    {
        // Arrange
        CookieDetails details = new()
        {
            Name = "test-remove-nameonly-details"
        };

        string value = "test-remove-nameonly-details-value";

        // Act
        Cookie cookieSet = await cookieService.SetAsync(details, value);

        Cookie cookieRemove = await cookieService.RemoveAsync(details);

        Cookie cookieGet = await cookieService.GetAsync(details);

        // Assert
        Assert.That(value, Is.EqualTo(cookieGet.Value));
        Assert.That(cookieGet, Is.EqualTo(null));
        Assert.That(cookieRemove, Is.EqualTo(cookieSet));
    }

    [Test]
    public async Task Remove_NameOnly()
    {
        // Arrange
        Cookie cookie = new()
        {
            Name = "test-remove-nameonly"
        };

        string value = "test-remove-nameonly-value";

        // Act
        Cookie cookieSet = await cookieService.SetAsync(cookie);

        Cookie cookieRemove = await cookieService.RemoveAsync(cookie);

        Cookie cookieGet = await cookieService.GetAsync(cookie.Name, cookie.Path, cookie.StoreId);

        // Assert
        Assert.That(value, Is.EqualTo(cookieGet.Value));
        Assert.That(cookieGet, Is.EqualTo(null));
        Assert.That(cookieRemove, Is.EqualTo(cookieSet));
    }
}
