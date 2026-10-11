using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using Disconance.Models.Interactions;

namespace Disconance.Models.Serialization;

internal sealed class InteractionEnvelopeConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type)
    {
        return type == typeof(Interaction) || type == typeof(InteractionResponse);
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        return (JsonConverter)Activator.CreateInstance(typeof(EnvelopeConverter<>).MakeGenericType(type))!;
    }

    private sealed class EnvelopeConverter<T> : JsonConverter<T>
    {
        private static JsonSerializerOptions WithoutEnvelope(JsonSerializerOptions options)
        {
            var copy = new JsonSerializerOptions(options);

            for (var i = copy.Converters.Count - 1; i >= 0; i--)
            {
                if (copy.Converters[i] is InteractionEnvelopeConverterFactory)
                {
                    copy.Converters.RemoveAt(i);
                }
            }

            return copy;
        }

        public override T? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            var node = JsonNode.Parse(ref reader)!.AsObject();
            var data = node["data"];
            var kind = node["type"]!.GetValue<int>();
            node.Remove("data");
            var value = node.Deserialize<T>(WithoutEnvelope(options))!;

            if (data is null)
            {
                return value;
            }

            if (value is Interaction interaction)
            {
                var dataType = kind switch
                {
                    2 or 4 => typeof(ApplicationCommandData),
                    3 => typeof(MessageComponentData),
                    5 => typeof(ModalSubmitData),
                    _ => throw new JsonException($"Unsupported interaction data discriminator: {kind}.")
                };

                interaction.Data = (InteractionData)data.Deserialize(dataType, options)!;
            }
            else if (value is InteractionResponse response)
            {
                var dataType = kind switch
                {
                    4 or 5 or 6 or 7 => typeof(InteractionMessageData),
                    8 => typeof(InteractionAutocompleteData),
                    9 => typeof(InteractionModalData),
                    _ => throw new JsonException($"Unsupported callback data discriminator: {kind}.")
                };

                response.Data = (InteractionResponseData)data.Deserialize(dataType, options)!;
            }

            return value;
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            JsonSerializer.Serialize(writer, value, WithoutEnvelope(options));
        }
    }
}