using System.Text.Json;
using System.Text.Json.Serialization.Metadata;

namespace Disconance.Models.Serialization;

/// <summary>
///     Creates the shared Discord wire-format configuration.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/reference#nullable-and-optional-resource-fields" />
public static class DiscordJson
{
    /// <summary>
    ///     Creates independent, customizable options. Unconfigured JSON serialization is unsupported.
    /// </summary>
    public static JsonSerializerOptions CreateOptions()
    {
        var resolver = new DefaultJsonTypeInfoResolver();

        resolver.Modifiers.Add(info =>
        {
            foreach (var property in info.Properties)
            {
                var type = property.PropertyType;

                if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>))
                {
                    var present = type.GetProperty(nameof(Optional<int>.HasValue))!;
                    property.ShouldSerialize = (_, value) => value is not null && (bool) present.GetValue(value)!;
                }
            }
        });

        var options = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            TypeInfoResolver = resolver
        };

        options.Converters.Add(new OptionalConverterFactory());
        options.Converters.Add(new SnowflakeConverter());
        options.Converters.Add(new PermissionConverter());
        options.Converters.Add(new NumericEnumConverterFactory());
        options.Converters.Add(new NullConverter());
        options.Converters.Add(new DiscordVariantConverterFactory());
        options.Converters.Add(new InteractionEnvelopeConverterFactory());
        options.Converters.Add(new CommandDataConverterFactory());
        return options;
    }
}