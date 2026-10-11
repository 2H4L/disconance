using Disconance.Http.Builders.Commands;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Tests.Builders.Commands;

public class TestApplicationCommandDefinitionBuilder
{
    [Fact]
    public void Build_NullDmPermission_PreservesExplicitNull()
    {
        var sut = new ApplicationCommandDefinitionBuilder().WithName("test").WithType(ApplicationCommandType.User)
            .WithDmPermission(null).WithDefaultPermission(false);

        var result = sut.Build();

        Assert.True(result.DmPermission.HasValue);
        Assert.Null(result.DmPermission.Value);
        Assert.False(result.DefaultPermission.Value);
    }

    [Fact]
    public void Build_ChatInputWithoutDescription_Throws()
    {
        var sut = new ApplicationCommandDefinitionBuilder().WithName("test").WithType(ApplicationCommandType.ChatInput);

        Assert.Throws<InvalidOperationException>(() => sut.Build());
    }
}