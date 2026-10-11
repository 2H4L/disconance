using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;
using Disconance.Models.Permissions;

namespace Disconance.Models.Serialization;

internal sealed class PermissionConverter : JsonConverter<PermissionFlags>
{
    public override PermissionFlags Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
    {
        if (reader.TokenType == JsonTokenType.String && ulong.TryParse(reader.GetString(), NumberStyles.None,
                CultureInfo.InvariantCulture, out var value))
        {
            return (PermissionFlags)value;
        }

        throw new JsonException("Expected decimal-string permissions.");
    }

    public override void Write(Utf8JsonWriter writer, PermissionFlags value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(((ulong)value).ToString(CultureInfo.InvariantCulture));
    }
}