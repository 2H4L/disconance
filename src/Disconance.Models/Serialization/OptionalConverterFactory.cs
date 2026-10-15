using System.Text.Json;
using System.Text.Json.Serialization;

namespace Disconance.Models.Serialization;

internal sealed class OptionalConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type)
    {
        return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>);
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        return (JsonConverter) Activator.CreateInstance(
            typeof(OptionalConverter<>).MakeGenericType(type.GetGenericArguments()))!;
    }

    private sealed class OptionalConverter<T> : JsonConverter<Optional<T>>
    {
        public override bool HandleNull => true;

        public override Optional<T> Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            return new Optional<T>(JsonSerializer.Deserialize<T>(ref reader, options)!);
        }

        public override void Write(Utf8JsonWriter writer, Optional<T> value, JsonSerializerOptions options)
        {
            if (!value.HasValue)
            {
                throw new JsonException("An absent optional cannot be serialized as a value.");
            }

            JsonSerializer.Serialize(writer, value.Value, options);
        }
    }
}