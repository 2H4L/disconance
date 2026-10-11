using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disconance.Models.Serialization;

internal sealed class SnowflakeConverter : JsonConverter<Snowflake>
{
    public override Snowflake Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.Number && reader.TryGetUInt64(out var number))
        {
            return new Snowflake(number);
        }

        if (reader.TokenType == JsonTokenType.String &&
            Snowflake.TryParse(reader.GetString(), out var value))
        {
            return value;
        }

        throw new JsonException("Expected an unsigned Discord snowflake.");
    }

    public override void Write(Utf8JsonWriter writer, Snowflake value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }

    public override Snowflake ReadAsPropertyName(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        return Snowflake.TryParse(reader.GetString(), out var value)
            ? value
            : throw new JsonException("Invalid snowflake key.");
    }

    public override void WriteAsPropertyName(Utf8JsonWriter writer, Snowflake value, JsonSerializerOptions options)
    {
        writer.WritePropertyName(value.ToString());
    }
}