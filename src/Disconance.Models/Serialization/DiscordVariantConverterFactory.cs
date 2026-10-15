using System.Text.Json;
using System.Text.Json.Serialization;
using Disconance.Models.Activities;
using Disconance.Models.Applications.IdentityProfiles;
using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;
using Disconance.Models.Messages;

namespace Disconance.Models.Serialization;

internal sealed class DiscordVariantConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type type)
    {
        return type == typeof(Component) || type == typeof(ComponentInteractionResponse) ||
               type == typeof(DynamicField) || type == typeof(MessageInteractionMetadata) ||
               type == typeof(InteractionData) || type == typeof(InteractionResponseData) ||
               typeof(CommandOptionValue).IsAssignableFrom(type) ||
               typeof(MessageNonce).IsAssignableFrom(type) || typeof(ActivityButtons).IsAssignableFrom(type);
    }

    public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
    {
        return (JsonConverter) Activator.CreateInstance(typeof(VariantConverter<>).MakeGenericType(type))!;
    }

    private static Type Resolve(Type type, int kind)
    {
        if (type == typeof(Component))
        {
            return kind switch
            {
                (int) ComponentType.ActionRow => typeof(ActionRow),
                (int) ComponentType.Button => typeof(Button),
                (int) ComponentType.ChannelSelect => typeof(ChannelSelect),
                (int) ComponentType.Checkbox => typeof(Checkbox),
                (int) ComponentType.CheckboxGroup => typeof(CheckboxGroup),
                (int) ComponentType.Container => typeof(Container),
                (int) ComponentType.File => typeof(FileComponent),
                (int) ComponentType.FileUpload => typeof(FileUpload),
                (int) ComponentType.Label => typeof(LabelComponent),
                (int) ComponentType.MediaGallery => typeof(MediaGallery),
                (int) ComponentType.MentionableSelect => typeof(MentionableSelect),
                (int) ComponentType.RadioGroup => typeof(RadioGroup),
                (int) ComponentType.RoleSelect => typeof(RoleSelect),
                (int) ComponentType.Section => typeof(Section),
                (int) ComponentType.Separator => typeof(Separator),
                (int) ComponentType.StringSelect => typeof(StringSelect),
                (int) ComponentType.TextDisplay => typeof(TextDisplay),
                (int) ComponentType.TextInput => typeof(TextInput),
                (int) ComponentType.Thumbnail => typeof(Thumbnail),
                (int) ComponentType.UserSelect => typeof(UserSelect),
                _ => throw new JsonException($"Unsupported Component discriminator: {kind}.")
            };
        }

        if (type == typeof(ComponentInteractionResponse))
        {
            return kind switch
            {
                (int) ComponentType.ActionRow => typeof(ActionRowInteractionResponse),
                (int) ComponentType.ChannelSelect => typeof(ChannelSelectInteractionResponse),
                (int) ComponentType.CheckboxGroup => typeof(CheckboxGroupInteractionResponse),
                (int) ComponentType.Checkbox => typeof(CheckboxInteractionResponse),
                (int) ComponentType.FileUpload => typeof(FileUploadInteractionResponse),
                (int) ComponentType.Label => typeof(LabelInteractionResponse),
                (int) ComponentType.MentionableSelect => typeof(MentionableSelectInteractionResponse),
                (int) ComponentType.RadioGroup => typeof(RadioGroupInteractionResponse),
                (int) ComponentType.RoleSelect => typeof(RoleSelectInteractionResponse),
                (int) ComponentType.StringSelect => typeof(StringSelectInteractionResponse),
                (int) ComponentType.TextDisplay => typeof(TextDisplayInteractionResponse),
                (int) ComponentType.TextInput => typeof(TextInputInteractionResponse),
                (int) ComponentType.UserSelect => typeof(UserSelectInteractionResponse),
                _ => throw new JsonException($"Unsupported ComponentInteractionResponse discriminator: {kind}.")
            };
        }

        if (type == typeof(DynamicField))
        {
            return kind switch
            {
                (int) DynamicFieldType.Media => typeof(DynamicMediaField),
                (int) DynamicFieldType.Number => typeof(DynamicNumberField),
                (int) DynamicFieldType.String => typeof(DynamicStringField),
                _ => throw new JsonException($"Unsupported DynamicField discriminator: {kind}.")
            };
        }

        if (type == typeof(MessageInteractionMetadata))
        {
            return kind switch
            {
                (int) InteractionType.ApplicationCommand => typeof(ApplicationCommandInteractionMetadata),
                (int) InteractionType.MessageComponent => typeof(MessageComponentInteractionMetadata),
                (int) InteractionType.ModalSubmit => typeof(ModalSubmitInteractionMetadata),
                _ => throw new JsonException($"Unsupported MessageInteractionMetadata discriminator: {kind}.")
            };
        }

        throw new JsonException($"Reading {type.Name} requires an enclosing discriminator.");
    }

    private sealed class VariantConverter<T> : JsonConverter<T>
    {
        public override T? Read(ref Utf8JsonReader reader, Type type, JsonSerializerOptions options)
        {
            using var document = JsonDocument.ParseValue(ref reader);
            var root = document.RootElement;
            object value;

            if (typeof(MessageNonce).IsAssignableFrom(type))
            {
                value = root.ValueKind == JsonValueKind.String
                    ? new StringMessageNonce(root.GetString()!)
                    : new IntegerMessageNonce(root.GetInt64());
            }
            else if (typeof(CommandOptionValue).IsAssignableFrom(type))
            {
                value = root.ValueKind switch
                {
                    JsonValueKind.String => new StringCommandValue(root.GetString()!),
                    JsonValueKind.Number when type != typeof(NumberCommandValue) && root.TryGetInt64(out var integer) =>
                        new IntegerCommandValue(integer),
                    JsonValueKind.Number => new NumberCommandValue(root.GetDouble()),
                    JsonValueKind.True or JsonValueKind.False when type == typeof(CommandOptionValue) ||
                                                                   type == typeof(BooleanCommandValue) =>
                        new BooleanCommandValue(root.GetBoolean()),
                    _ => throw new JsonException("Unsupported command scalar.")
                };
            }
            else if (typeof(ActivityButtons).IsAssignableFrom(type))
            {
                if (root.ValueKind != JsonValueKind.Array)
                {
                    throw new JsonException("Expected activity buttons array.");
                }

                value = type != typeof(ActivityButtonLinks) &&
                        (root.GetArrayLength() == 0 || root[0].ValueKind == JsonValueKind.String)
                    ? new ActivityButtonLabels(root.Deserialize<List<string>>(options)!)
                    : new ActivityButtonLinks(root.Deserialize<List<ActivityButton>>(options)!);
            }
            else
            {
                value = root.Deserialize(Resolve(type, root.GetProperty("type").GetInt32()), options)!;
            }

            return value is T typed ? typed : throw new JsonException($"Value does not match {type.Name}.");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            switch (value)
            {
                case StringCommandValue v: writer.WriteStringValue(v.Value); break;
                case IntegerCommandValue v: writer.WriteNumberValue(v.Value); break;
                case NumberCommandValue v: writer.WriteNumberValue(v.Value); break;
                case BooleanCommandValue v: writer.WriteBooleanValue(v.Value); break;
                case StringMessageNonce v: writer.WriteStringValue(v.Value); break;
                case IntegerMessageNonce v: writer.WriteNumberValue(v.Value); break;
                case ActivityButtonLabels v: JsonSerializer.Serialize(writer, v.Labels, options); break;
                case ActivityButtonLinks v: JsonSerializer.Serialize(writer, v.Buttons, options); break;
                default: JsonSerializer.Serialize(writer, value, value!.GetType(), options); break;
            }
        }
    }
}