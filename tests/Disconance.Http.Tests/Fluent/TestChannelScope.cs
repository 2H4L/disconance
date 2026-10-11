using System.Net;
using Disconance.Http.Fluent;
using Disconance.Http.Requests;
using Disconance.Http.Requests.Messages;
using Disconance.Http.Responses;
using Disconance.Models.Messages;

namespace Disconance.Http.Tests.Fluent;

public class TestChannelScope
{
    [Fact]
    public async Task Create_NestedBuilder_SendsTypedSnapshot()
    {
        var sender = new CapturingSender();
        var sut = sender.Channel(42);

        await sut.Messages.Create().WithContent("Hello")
            .AddEmbed(embed => embed.WithTitle("Status").AddField(field => field.WithName("status").WithValue("ready")))
            .SendAsync();

        var payload = Assert.IsType<CreateMessageBody>(sender.Request!.Body);
        Assert.Equal("Hello", payload.Content.Value);
        Assert.Equal("ready", payload.Embeds.Value[0].Fields.Value[0].Value);
        Assert.Equal("channels/{channel.id}/messages", sender.Request.Route.Template);
    }
}

internal sealed class CapturingSender : IDiscordRequestSender
{
    internal IDiscordRequest<Message>? Request { get; private set; }

    public Task<DiscordResponse<T>> SendAsync<T>(IDiscordRequest<T> request,
        CancellationToken cancellationToken = default)
    {
        Request = request as IDiscordRequest<Message>;
        return Task.FromResult(new DiscordResponse<T> { StatusCode = HttpStatusCode.OK, HasBody = false });
    }
}
