using Disconance.Http.Requests;

namespace Disconance.Http.Tests.Requests;

public class TestDiscordRoute
{
    [Theory]
    [InlineData("https://other.example/path")]
    [InlineData("/users/@me")]
    [InlineData("../users/@me")]
    [InlineData("users/@me?token=secret")]
    public void Constructor_NonRelativeTemplate_Throws(string template)
    {
        Assert.Throws<ArgumentException>(() => new DiscordRoute(template));
    }

    [Theory]
    [InlineData(".")]
    [InlineData("..")]
    [InlineData("")]
    public void Constructor_InvalidParameter_Throws(string parameter)
    {
        Assert.Throws<ArgumentException>(() => new DiscordRoute("channels/{channel.id}",
            new Dictionary<string, string> { ["channel.id"] = parameter }));
    }
}