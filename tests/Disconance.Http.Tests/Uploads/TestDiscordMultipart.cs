using System.Text.Json;
using Disconance.Http.Requests.Messages;
using Disconance.Http.Uploads;
using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Tests.Uploads;

public class TestDiscordMultipart
{
    [Fact]
    public async Task CreateFactory_RepeatedAttempts_ReopensStreamsAndMatchesIndices()
    {
        var opened = new List<MemoryStream>();

        var payload = new EditMessageBody
            { Attachments = new List<PartialAttachment> { new() { Id = new Snowflake(99) } } };

        var file = new DiscordFile("test.txt", () =>
        {
            var stream = new MemoryStream([1, 2, 3]);
            opened.Add(stream);
            return stream;
        });

        var sut = DiscordMultipart.CreateFactory(payload, [file]);

        using (var first = (MultipartFormDataContent) sut())
        {
            var parts = first.ToArray();
            using var json = JsonDocument.Parse(await parts[0].ReadAsStringAsync());
            Assert.Equal("99", json.RootElement.GetProperty("attachments")[0].GetProperty("id").GetString());
            Assert.Equal(0, json.RootElement.GetProperty("attachments")[1].GetProperty("id").GetInt32());
            Assert.Equal("files[0]", parts[1].Headers.ContentDisposition!.Name!.Trim('"'));
        }

        using (sut())
        {
        }

        Assert.Equal(2, opened.Count);
        Assert.All(opened, stream => Assert.False(stream.CanRead));
    }
}