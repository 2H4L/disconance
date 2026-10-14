using Disconance.Interactions.Commands;
using Disconance.Interactions.Components;
using Disconance.Interactions.Modals;
using Disconance.Interactions.Tests.Commands;
using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Tests;

public class TestDefaultInteractionHandler
{
    [Fact]
    public async Task HandleAsync_Command_PassesContextAndCancellation()
    {
        using var cancellation = new CancellationTokenSource();
        var command = new CommandTestData.Ping();
        var interaction = CommandTestData.Interaction(data: CommandTestData.Data("ping"));
        var sut = new DefaultInteractionHandler(new CommandCatalog([command], [], []), [], []);

        var response = await sut.HandleAsync(interaction, cancellation.Token);

        Assert.Equal("pong", Assert.IsType<InteractionMessageData>(response!.Data.Value).Content.Value);
        Assert.Same(interaction, command.Received!.Interaction);
        Assert.Equal(cancellation.Token, command.Cancellation);
    }

    [Fact]
    public async Task HandleAsync_NestedAutocomplete_PassesFocusedLeafOptions()
    {
        var command = new CommandTestData.Ban();

        var focused = new ApplicationCommandInteractionDataOption
        {
            Name = "reason", Type = ApplicationCommandOptionType.String, Focused = true
        };

        var data = CommandTestData.Data("admin",
            CommandTestData.Nested("users", ApplicationCommandOptionType.SubCommandGroup,
                CommandTestData.Nested("ban", ApplicationCommandOptionType.SubCommand, focused)));

        var sut = new DefaultInteractionHandler(
            new CommandCatalog([], [new CommandTestData.Admin(), new CommandTestData.Users()], [command]), [], []);

        var response =
            await sut.HandleAsync(CommandTestData.Interaction(InteractionType.ApplicationCommandAutocomplete, data));

        Assert.Equal(InteractionCallbackType.ApplicationCommandAutocompleteResult, response!.Type);
        Assert.Same(focused, Assert.Single(command.Received!.Options));
    }

    [Theory]
    [InlineData(InteractionType.MessageComponent)]
    [InlineData(InteractionType.ModalSubmit)]
    public async Task HandleAsync_CustomIdWithApplicationState_PreservesCompleteId(InteractionType type)
    {
        var handler = new CustomIdHandler();
        var interaction = CommandTestData.Interaction(type);

        interaction.Data = type == InteractionType.MessageComponent
            ? new MessageComponentData { CustomId = "order:123|confirm", ComponentType = ComponentType.Button }
            : new ModalSubmitData { CustomId = "order:123|confirm", Components = [] };

        var sut = new DefaultInteractionHandler(new CommandCatalog([], [], []), [handler], [handler]);

        var response = await sut.HandleAsync(interaction);

        Assert.NotNull(response);
        Assert.Equal("order:123|confirm", handler.ReceivedId);
    }

    [Fact]
    public async Task HandleAsync_AmbiguousCustomId_RejectsWithoutExecutingHandlers()
    {
        var handler = new CustomIdHandler();
        var interaction = CommandTestData.Interaction(InteractionType.MessageComponent);
        interaction.Data = new MessageComponentData { CustomId = "order:1", ComponentType = ComponentType.Button };
        var sut = new DefaultInteractionHandler(new CommandCatalog([], [], []), [handler, new CustomIdHandler()], []);

        await Assert.ThrowsAsync<InvalidOperationException>(() => sut.HandleAsync(interaction));

        Assert.Null(handler.ReceivedId);
    }

    [Fact]
    public async Task HandleAsync_CancelledRequest_DoesNotExecute()
    {
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        var command = new CommandTestData.Ping();
        var sut = new DefaultInteractionHandler(new CommandCatalog([command], [], []), [], []);

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() =>
            sut.HandleAsync(CommandTestData.Interaction(data: CommandTestData.Data("ping")), cancellation.Token));

        Assert.Null(command.Received);
    }

    private sealed class CustomIdHandler : IMessageComponentHandler, IModalSubmitHandler
    {
        public string? ReceivedId { get; private set; }

        public bool CanHandle(string customId)
        {
            return customId.StartsWith("order:", StringComparison.Ordinal);
        }

        public Task<InteractionResponse> ExecuteAsync(Interaction interaction, MessageComponentData data,
            CancellationToken cancellationToken)
        {
            ReceivedId = data.CustomId;
            return Task.FromResult(CommandTestData.Response("component"));
        }

        public Task<InteractionResponse> ExecuteAsync(Interaction interaction, ModalSubmitData data,
            CancellationToken cancellationToken)
        {
            ReceivedId = data.CustomId;
            return Task.FromResult(CommandTestData.Response("modal"));
        }
    }
}