using System.Buffers;
using System.Text;
using System.Text.Json;
using Disconance.Interactions.Middleware;
using Disconance.Models.Interactions;
using Disconance.Models.Serialization;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using NSec.Cryptography;

namespace Disconance.Interactions.Hosting;

internal sealed class InteractionEndpoint
{
    private readonly JsonSerializerOptions _json = DiscordJson.CreateOptions();
    private readonly int _maxRequestBodySize;
    private readonly PublicKey _publicKey;

    public InteractionEndpoint(IOptions<DiscordInteractionOptions> options)
    {
        var value = options.Value;

        _publicKey = PublicKey.Import(SignatureAlgorithm.Ed25519,
            Convert.FromHexString(value.PublicKey), KeyBlobFormat.RawPublicKey);

        _maxRequestBodySize = value.MaxRequestBodySize;
    }

    internal async Task<IResult> HandleAsync(HttpContext context)
    {
        var request = context.Request;
        var cancellationToken = context.RequestAborted;
        var signatures = request.Headers["X-Signature-Ed25519"];
        var timestamps = request.Headers["X-Signature-Timestamp"];

        if (signatures.Count != 1 || timestamps.Count != 1 ||
            signatures[0] is not { Length: 128 } signature ||
            !signature.All(char.IsAsciiHexDigit) ||
            timestamps[0] is not { Length: > 0 and <= 20 } timestamp ||
            !timestamp.All(char.IsAsciiDigit))
        {
            return Results.Unauthorized();
        }

        if (request.ContentLength > _maxRequestBodySize)
        {
            return Results.StatusCode(StatusCodes.Status413PayloadTooLarge);
        }

        using var body = new MemoryStream();
        var buffer = ArrayPool<byte>.Shared.Rent(81920);

        try
        {
            while (true)
            {
                var readSize = (int) Math.Min(buffer.Length, _maxRequestBodySize - body.Length + 1);
                var read = await request.Body.ReadAsync(buffer.AsMemory(0, readSize), cancellationToken);

                if (read == 0)
                {
                    break;
                }

                if (body.Length + read > _maxRequestBodySize)
                {
                    return Results.StatusCode(StatusCodes.Status413PayloadTooLarge);
                }

                body.Write(buffer, 0, read);
            }
        }
        finally
        {
            ArrayPool<byte>.Shared.Return(buffer);
        }

        var bodyBytes = body.GetBuffer().AsMemory(0, (int) body.Length);
        var timestampBytes = Encoding.UTF8.GetBytes(timestamp);
        var signedBytes = new byte[timestampBytes.Length + bodyBytes.Length];
        timestampBytes.CopyTo(signedBytes, 0);
        bodyBytes.CopyTo(signedBytes.AsMemory(timestampBytes.Length));

        if (!SignatureAlgorithm.Ed25519.Verify(_publicKey, signedBytes, Convert.FromHexString(signature)))
        {
            return Results.Unauthorized();
        }

        Interaction interaction;

        try
        {
            using var document = JsonDocument.Parse(bodyBytes);
            var root = document.RootElement;

            if (root.ValueKind != JsonValueKind.Object ||
                !root.TryGetProperty("type", out var type) ||
                !type.TryGetInt32(out var kind))
            {
                return Results.BadRequest();
            }

            if (kind == (int) InteractionType.Ping)
            {
                return Json(new InteractionResponse { Type = InteractionCallbackType.Pong });
            }

            if (kind is < 2 or > 5 ||
                !root.TryGetProperty("data", out var data) || data.ValueKind != JsonValueKind.Object)
            {
                return Results.BadRequest();
            }

            interaction = root.Deserialize<Interaction>(_json)!;

            if ((interaction.Data.Value is ApplicationCommandData command && string.IsNullOrWhiteSpace(command.Name)) ||
                (interaction.Data.Value is MessageComponentData component &&
                 string.IsNullOrEmpty(component.CustomId)) ||
                (interaction.Data.Value is ModalSubmitData modal &&
                 (string.IsNullOrEmpty(modal.CustomId) || modal.Components is null)))
            {
                return Results.BadRequest();
            }
        }
        catch (Exception exception) when (exception is JsonException or InvalidOperationException or FormatException
                                              or ArgumentException)
        {
            return Results.BadRequest();
        }

        InteractionDelegate next = () => context.RequestServices.GetRequiredService<IInteractionHandler>()
            .HandleAsync(interaction, cancellationToken);

        var middleware = context.RequestServices.GetServices<IInteractionMiddleware>().ToArray();

        for (var index = middleware.Length - 1; index >= 0; index--)
        {
            var current = middleware[index];
            var following = next;
            next = () => current.InvokeAsync(interaction, following, cancellationToken);
        }

        var response = await next();
        return response is null ? Results.NotFound() : Json(response);
    }

    private IResult Json(InteractionResponse response)
    {
        return Results.Bytes(JsonSerializer.SerializeToUtf8Bytes(response, _json), "application/json");
    }
}