using BlazorCookies.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BlazorCookies.Tests.Unit;

public partial class CookieServiceTests
{
    //[Test]
    public async Task Remove_NameOnly_Details()
    {
        // Arrange
        CookieDetails details = new("test-remove-nameonly-details");

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

    //[Test]
    public async Task Remove_NameOnly()
    {
        // Arrange
        string name = "test-remove-nameonly";

        string value = "test-remove-nameonly-value";

        // Act
        Cookie cookieSet = await cookieService.SetAsync(name, value);

        Cookie cookieRemove = await cookieService.RemoveAsync(name);

        Cookie cookieGet = await cookieService.GetAsync(name);

        // Assert
        Assert.That(value, Is.EqualTo(cookieGet.Value));
        Assert.That(cookieGet, Is.EqualTo(null));
        Assert.That(cookieRemove, Is.EqualTo(cookieSet));
    }
}
