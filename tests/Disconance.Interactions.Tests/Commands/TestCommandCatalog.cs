using System.Text.Json;
using Disconance.Interactions.Commands;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Serialization;

namespace Disconance.Interactions.Tests.Commands;

public class TestCommandCatalog
{
    [Fact]
    public void Find_ChildGroupRegisteredBeforeParent_SelectsHandler()
    {
        var handler = new CommandTestData.Ban();
        var sut = new CommandCatalog([], [new CommandTestData.Users(), new CommandTestData.Admin()], [handler]);

        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("users", ApplicationCommandOptionType.SubCommandGroup,
                CommandTestData.Nested("ban", ApplicationCommandOptionType.SubCommand)));

        var match = sut.Find(data);

        Assert.NotNull(match);
        Assert.Same(handler, match.Value.Handler);
    }

    [Theory]
    [InlineData("""{"id":"1","name":null,"type":1}""")]
    [InlineData("""{"id":"1","name":"admin","type":1,"options":[null]}""")]
    [InlineData("""{"id":"1","name":"admin","type":1,"options":[{"name":null,"type":1}]}""")]
    [InlineData("""{"id":"1","name":"admin","type":1,"options":[{"name":"status","type":1,"value":"unexpected"}]}""")]
    [InlineData("""{"id":"1","name":"admin","type":1,"options":[{"name":"status","type":1,"options":[{"name":"extra","type":1}]}]}""")]
    public void Find_MalformedCommandData_ReturnsNoMatch(string json)
    {
        var data = JsonSerializer.Deserialize<ApplicationCommandData>(json, DiscordJson.CreateOptions())!;
        var sut = new CommandCatalog([], [new CommandTestData.Admin()], [new CommandTestData.Status()]);

        var match = sut.Find(data);

        Assert.Null(match);
    }

    [Fact]
    public void Find_NullParameter_ReturnsNoMatch()
    {
        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("status", ApplicationCommandOptionType.SubCommand, [null!]));

        var sut = new CommandCatalog([], [new CommandTestData.Admin()], [new CommandTestData.Status()]);

        var match = sut.Find(data);

        Assert.Null(match);
    }

    [Theory]
    [InlineData("""{"id":"1","name":"ping","type":1}""")]
    [InlineData("""{"id":"1","name":"ping","type":1,"options":null}""")]
    public void Find_AbsentOrNullOptions_SelectsParameterlessCommand(string json)
    {
        var handler = new CommandTestData.Ping();
        var data = JsonSerializer.Deserialize<ApplicationCommandData>(json, DiscordJson.CreateOptions())!;
        var sut = new CommandCatalog([handler], [], []);

        var match = sut.Find(data);

        Assert.NotNull(match);
        Assert.Same(handler, match.Value.Handler);
        Assert.Empty(match.Value.Options);
    }

    [Fact]
    public void Definitions_GroupHierarchy_ComposesDiscordOptions()
    {
        var sut = new CommandCatalog([], [new CommandTestData.Admin(), new CommandTestData.Users()],
            [new CommandTestData.Ban(), new CommandTestData.Status()]);

        var definition = Assert.Single(sut.Definitions);

        Assert.Equal("admin", definition.Name);
        Assert.Equal(ApplicationCommandType.ChatInput, definition.Type);
        Assert.Equal(2, definition.Options.Value.Count);
        var users = Assert.Single(definition.Options.Value, option => option.Name == "users");
        Assert.Equal(ApplicationCommandOptionType.SubCommandGroup, users.Type);
        var ban = Assert.Single(users.Options.Value);
        Assert.Equal(ApplicationCommandOptionType.SubCommand, ban.Type);
        Assert.Equal("ban", ban.Name);
        Assert.Equal("reason", Assert.Single(ban.Options.Value).Name);
    }

    [Fact]
    public void Definitions_SameNameDifferentCommandTypes_KeepsBothCommands()
    {
        var sut = new CommandCatalog(
            [new CommandTestData.Ping(), new CommandTestData.Ping(ApplicationCommandType.User)], [], []);

        var definitions = sut.Definitions;

        Assert.Equal(2, definitions.Count);
    }

    [Fact]
    public void Constructor_DuplicateCommandIdentity_RejectsAmbiguousDispatch()
    {
        Assert.Throws<InvalidOperationException>(() =>
            new CommandCatalog([new CommandTestData.Ping(), new CommandTestData.Ping()], [], []));
    }

    [Fact]
    public void Constructor_UnregisteredParent_RejectsIncompleteHierarchy()
    {
        Assert.Throws<InvalidOperationException>(() =>
            new CommandCatalog([], [], [new CommandTestData.Status()]));
    }

    [Fact]
    public void Constructor_EmptyGroup_RejectsUncallableGroup()
    {
        Assert.Throws<InvalidOperationException>(() =>
            new CommandCatalog([], [new CommandTestData.Admin()], []));
    }

    [Fact]
    public void Constructor_DuplicateChildName_RejectsAmbiguousDispatch()
    {
        Assert.Throws<InvalidOperationException>(() =>
            new CommandCatalog([], [new CommandTestData.Admin()],
                [new CommandTestData.Status(), new CommandTestData.Status()]));
    }

    [Fact]
    public void Find_NestedSubcommand_SelectsHandlerAndUnwrapsParameters()
    {
        var handler = new CommandTestData.Ban();

        var parameter = new ApplicationCommandInteractionDataOption
        {
            Name = "reason", Type = ApplicationCommandOptionType.String, Focused = true
        };

        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("users", ApplicationCommandOptionType.SubCommandGroup,
                CommandTestData.Nested("ban", ApplicationCommandOptionType.SubCommand, parameter)));

        var sut = new CommandCatalog([], [new CommandTestData.Admin(), new CommandTestData.Users()], [handler]);

        var match = sut.Find(data);

        Assert.NotNull(match);
        Assert.Same(handler, match.Value.Handler);
        Assert.Same(parameter, Assert.Single(match.Value.Options));
    }

    [Theory]
    [InlineData("missing", ApplicationCommandOptionType.SubCommand)]
    [InlineData("status", ApplicationCommandOptionType.SubCommandGroup)]
    public void Find_UnknownOrWronglyTypedChild_ReturnsNoMatch(string name, ApplicationCommandOptionType type)
    {
        var sut = new CommandCatalog([], [new CommandTestData.Admin()], [new CommandTestData.Status()]);

        var match = sut.Find(CommandTestData.Data("admin", CommandTestData.Nested(name, type)));

        Assert.Null(match);
    }

    [Fact]
    public void Find_MultipleSubcommands_ReturnsNoMatch()
    {
        var sut = new CommandCatalog([], [new CommandTestData.Admin()], [new CommandTestData.Status()]);

        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("status", ApplicationCommandOptionType.SubCommand),
            CommandTestData.Nested("status", ApplicationCommandOptionType.SubCommand));

        var match = sut.Find(data);

        Assert.Null(match);
    }
}
