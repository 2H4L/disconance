using System.Net;
using Disconance.Http;
using Disconance.Http.Requests;
using Disconance.Http.Requests.Commands;
using Disconance.Http.Responses;
using Disconance.Interactions.Commands;
using Disconance.Models;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Interactions.Tests.Commands;

public class TestCommandRegistrationService
{
    [Theory]
    [InlineData(false)]
    [InlineData(true)]
    public async Task RegisterCommandsAsync_RegisteredDefinitions_UpsertsToRequestedScope(bool guild)
    {
        using var cancellation = new CancellationTokenSource();
        var sender = new RecordingSender();

        var sut = new CommandRegistrationService(
            new CommandCatalog([new CommandTestData.Ping()], [new CommandTestData.Admin()],
                [new CommandTestData.Status()]),
            sender);

        if (guild)
        {
            await sut.RegisterGuildCommandsAsync(new Snowflake(42), new Snowflake(84), cancellation.Token);
        }
        else
        {
            await sut.RegisterGlobalCommandsAsync(new Snowflake(42), cancellation.Token);
        }

        Assert.Equal(2, sender.Requests.Count);

        Assert.All(sender.Requests, request =>
        {
            Assert.Equal(HttpMethod.Post, request.Method);

            Assert.Equal(guild
                ? "applications/{application.id}/guilds/{guild.id}/commands"
                : "applications/{application.id}/commands", request.Route.Template);

            Assert.IsType(
                guild ? typeof(CreateGuildApplicationCommandRequest) : typeof(CreateGlobalApplicationCommandRequest),
                request);
        });

        Assert.Equal(["ping", "admin"], sender.Requests.Select(request =>
            Assert.IsType<ApplicationCommandDefinition>(request.Body).Name));

        Assert.Equal(cancellation.Token, sender.Cancellation);
    }

    [Fact]
    public async Task RegisterGlobalCommandsAsync_EmptyCatalog_DoesNotSend()
    {
        var sender = new RecordingSender();
        var sut = new CommandRegistrationService(new CommandCatalog([], [], []), sender);

        await sut.RegisterGlobalCommandsAsync(new Snowflake(42));

        Assert.Empty(sender.Requests);
    }

    [Fact]
    public async Task RegisterGlobalCommandsAsync_ZeroApplicationId_RejectsBeforeSending()
    {
        var sender = new RecordingSender();
        var sut = new CommandRegistrationService(new CommandCatalog([new CommandTestData.Ping()], [], []), sender);

        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() => sut.RegisterGlobalCommandsAsync(default));

        Assert.Empty(sender.Requests);
    }

    [Fact]
    public async Task RegisterGuildCommandsAsync_ZeroGuildId_RejectsBeforeSending()
    {
        var sender = new RecordingSender();
        var sut = new CommandRegistrationService(new CommandCatalog([new CommandTestData.Ping()], [], []), sender);

        await Assert.ThrowsAsync<ArgumentOutOfRangeException>(() =>
            sut.RegisterGuildCommandsAsync(new Snowflake(42), default));

        Assert.Empty(sender.Requests);
    }

    [Fact]
    public async Task RegisterGlobalCommandsAsync_Cancelled_DoesNotSend()
    {
        using var cancellation = new CancellationTokenSource();
        cancellation.Cancel();
        var sender = new RecordingSender();
        var sut = new CommandRegistrationService(new CommandCatalog([new CommandTestData.Ping()], [], []), sender);

        await Assert.ThrowsAnyAsync<OperationCanceledException>(() =>
            sut.RegisterGlobalCommandsAsync(new Snowflake(42), cancellation.Token));

        Assert.Empty(sender.Requests);
    }

    private sealed class RecordingSender : IDiscordRequestSender
    {
        internal List<IDiscordRequest<ApplicationCommand>> Requests { get; } = [];

        internal CancellationToken Cancellation { get; private set; }

        public Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request,
            CancellationToken cancellationToken = default)
        {
            Requests.Add(Assert.IsType<IDiscordRequest<ApplicationCommand>>(request, false));
            Cancellation = cancellationToken;

            return Task.FromResult(new DiscordResponse<T>
            {
                StatusCode = HttpStatusCode.OK, HasBody = false
            });
        }
    }
}