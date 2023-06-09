using BlazorCookies.Models;
using NUnit.Framework;
using System.Threading.Tasks;

namespace BlazorCookies.Tests.Unit;

public partial class CookieServiceTests
{
    //[Test]
    public async Task GetSet_NameOnly()
    {
        // Arrange
        CookieDetails details = new("test-getset_nameonly");

        string value = "test-getset_nameonly-value";

        // Act
        Cookie cookieSet = await cookieService.SetAsync(details, value);

        Cookie cookieGet = await cookieService.GetAsync(details.Name);

        // Assert
        Assert.That(value, Is.EqualTo(cookieGet.Value));
        Assert.That(cookieGet, Is.EqualTo(cookieSet));
    }
}
