using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disconance.Models.Serialization;

internal sealed class NullConverter : JsonConverter<DiscordNull>
{
    public override bool HandleNull => true;

    public override DiscordNull Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        return reader.TokenType == JsonTokenType.Null ? default : throw new JsonException("Expected literal null.");
    }

    public override void Write(Utf8JsonWriter writer, DiscordNull value, JsonSerializerOptions options)
    {
        writer.WriteNullValue();
    }
}