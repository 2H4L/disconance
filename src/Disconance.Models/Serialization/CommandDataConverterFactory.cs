using System.Text.Json;
using System.Text.Json.Serialization;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Models.Serialization;

internal sealed class CommandDataConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type)
    {
        return type == typeof(ApplicationCommandOption) || type == typeof(ApplicationCommandInteractionDataOption);
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        return (JsonConverter) Activator.CreateInstance(typeof(CommandConverter<>).MakeGenericType(type))!;
    }

    private static void Normalize(ApplicationCommandOption option)
    {
        if (option.Type == ApplicationCommandOptionType.Number && option.Choices.HasValue)
        {
            foreach (var choice in option.Choices.Value)
            {
                if (choice.Value is IntegerCommandValue integer)
                {
                    choice.Value = new NumberCommandValue(integer.Value);
                }
            }
        }

        if (option.Options.HasValue)
        {
            foreach (var child in option.Options.Value)
            {
                Normalize(child);
            }
        }
    }

    private static void Normalize(ApplicationCommandInteractionDataOption option)
    {
        if (option.Type == ApplicationCommandOptionType.Number && option.Value.HasValue &&
            option.Value.Value is IntegerCommandValue integer)
        {
            option.Value = new NumberCommandValue(integer.Value);
        }

        if (option.Options.HasValue)
        {
            foreach (var child in option.Options.Value)
            {
                Normalize(child);
            }
        }
    }

    private sealed class CommandConverter<T> : JsonConverter<T>
    {
        private static JsonSerializerOptions WithoutSelf(JsonSerializerOptions options)
        {
            var copy = new JsonSerializerOptions(options);

            for (var i = copy.Converters.Count - 1; i >= 0; i--)
            {
                if (copy.Converters[i] is CommandDataConverterFactory)
                {
                    copy.Converters.RemoveAt(i);
                }
            }

            return copy;
        }

        public override T? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            var value = JsonSerializer.Deserialize<T>(ref reader, WithoutSelf(options));

            if (value is ApplicationCommandOption definition)
            {
                Normalize(definition);
            }

            if (value is ApplicationCommandInteractionDataOption input)
            {
                Normalize(input);
            }

            return value;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, WithoutSelf(options));
        }
    }
}