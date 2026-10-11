using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disconance.Models.Serialization;

internal sealed class NumericEnumConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type)
    {
        return type.IsEnum;
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        return (JsonConverter)Activator.CreateInstance(typeof(EnumConverter<>).MakeGenericType(type))!;
    }

    private sealed class EnumConverter<T> : JsonConverter<T> where T : struct, Enum
    {
        private static readonly bool Unsigned = Enum.GetUnderlyingType(typeof(T)) == typeof(ulong);

        public override T Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.Number)
            {
                throw new JsonException("Expected a numeric enum.");
            }

            return Unsigned ? (T)Enum.ToObject(type, reader.GetUInt64()) : FromSigned(reader.GetInt64());
        }

        private static T FromSigned(long value)
        {
            try
            {
                return (T)Enum.ToObject(typeof(T),
                    Convert.ChangeType(value, Enum.GetUnderlyingType(typeof(T)), CultureInfo.InvariantCulture));
            }
            catch (OverflowException exception)
            {
                throw new JsonException("Enum value exceeds its underlying range.", exception);
            }
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            if (Unsigned)
            {
                writer.WriteNumberValue(Convert.ToUInt64(value, CultureInfo.InvariantCulture));
            }
            else
            {
                writer.WriteNumberValue(Convert.ToInt64(value, CultureInfo.InvariantCulture));
            }
        }

        public override T ReadAsPropertyName(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            if (Unsigned && ulong.TryParse(reader.GetString(), NumberStyles.None, CultureInfo.InvariantCulture,
                    out var unsigned))
            {
                return (T)Enum.ToObject(type, unsigned);
            }

            if (!Unsigned && long.TryParse(reader.GetString(), NumberStyles.AllowLeadingSign,
                    CultureInfo.InvariantCulture, out var signed))
            {
                return FromSigned(signed);
            }

            throw new JsonException("Expected a numeric enum dictionary key.");
        }

        public override void WriteAsPropertyName(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WritePropertyName(Unsigned
                ? Convert.ToUInt64(value, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture)
                : Convert.ToInt64(value, CultureInfo.InvariantCulture).ToString(CultureInfo.InvariantCulture));
        }
    }
}