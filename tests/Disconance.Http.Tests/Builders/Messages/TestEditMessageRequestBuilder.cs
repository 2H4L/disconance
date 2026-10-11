using System.Text.Json;
using Disconance.Http.Fluent;
using Disconance.Http.Tests.Fluent;
using Disconance.Models.Serialization;

namespace Disconance.Http.Tests.Builders.Messages;

public class TestEditMessageRequestBuilder
{
    [Fact]
    public void Build_NullCollectionsAndFlags_PreservesExplicitNull()
    {
        var sender = new CapturingSender();
        var sut = sender.Channel(42).Messages.Edit(43).ClearEmbeds().ClearFlags();

        var result = sut.Build();

        Assert.Equal("{\"embeds\":null,\"flags\":null}",
            JsonSerializer.Serialize(result.Payload, DiscordJson.CreateOptions()));
    }

    [Fact]
    public void Build_AddAfterClear_ReplacesNullWithCollection()
    {
        var sender = new CapturingSender();
        var sut = sender.Channel(42).Messages.Edit(43).ClearEmbeds().AddEmbed(embed => embed.WithTitle("new"));

        var result = sut.Build();

        Assert.Single(result.Payload.Embeds.Value!);
    }

    [Fact]
    public void Build_ClearedContentAndEmptyEmbeds_PreservesIntent()
    {
        var sender = new CapturingSender();
        var sut = sender.Channel(42).Messages.Edit(43).WithContent("old").ClearContent().WithEmbeds([]);

        var result = sut.Build();

        Assert.Equal("{\"content\":null,\"embeds\":[]}",
            JsonSerializer.Serialize(result.Payload, DiscordJson.CreateOptions()));
    }
}