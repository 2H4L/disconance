using System.Globalization;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using Disconance.Models.Interactions;
using Disconance.Models.Serialization;

namespace Disconance.Http.Uploads;

/// <summary>
///     Creates multipart payloads with matching attachment IDs and fresh per-attempt streams.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/reference#uploading-files" />
internal static class DiscordMultipart
{
    /// <summary>
    ///     Snapshots JSON and upload metadata; existing attachment entries are retained.
    /// </summary>
    public static Func<HttpContent> CreateFactory(object payload, IReadOnlyList<DiscordFile> files)
    {
        ArgumentNullException.ThrowIfNull(payload);
        ArgumentNullException.ThrowIfNull(files);

        var uploads = files.ToArray();
        var root = JsonSerializer.SerializeToNode(payload, payload.GetType(), DiscordJson.CreateOptions())!.AsObject();

        var target = payload is InteractionResponse
            ? root["data"]?.AsObject() ??
              throw new ArgumentException("File callbacks require message data.", nameof(payload))
            : root;

        var attachments = target["attachments"]?.AsArray() ?? [];
        target["attachments"] ??= attachments;

        var indices = new List<int>();
        var next = 0;

        foreach (var file in uploads)
        {
            while (attachments.Any(a => a?["id"]?.ToString() == next.ToString(CultureInfo.InvariantCulture)))
            {
                next++;
            }

            indices.Add(next);
            var attachment = new JsonObject { ["id"] = next++, ["filename"] = file.Filename };

            if (file.Description is not null)
            {
                attachment["description"] = file.Description;
            }

            attachments.Add(attachment);
        }

        var json = root.ToJsonString();

        return () =>
        {
            var content = new MultipartFormDataContent();

            try
            {
                content.Add(new StringContent(json, Encoding.UTF8, "application/json"), "payload_json");

                for (var i = 0; i < uploads.Length; i++)
                {
                    var file = uploads[i];
                    var mediaType = MediaTypeHeaderValue.Parse(file.ContentType);

                    var stream = file.OpenRead() ??
                                 throw new InvalidOperationException("An upload factory returned no stream.");

                    var part = new StreamContent(stream);

                    try
                    {
                        if (!stream.CanRead)
                        {
                            throw new InvalidOperationException("Upload streams must be readable.");
                        }

                        part.Headers.ContentType = mediaType;
                        content.Add(part, $"files[{indices[i]}]", file.Filename);
                    }
                    catch
                    {
                        part.Dispose();
                        throw;
                    }
                }

                return content;
            }
            catch
            {
                content.Dispose();
                throw;
            }
        };
    }
}