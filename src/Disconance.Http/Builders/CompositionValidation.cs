using Disconance.Models.Components;
using Disconance.Models.Interactions;
using Disconance.Models.Interactions.Commands;

namespace Disconance.Http.Builders;

internal static class CompositionValidation
{
    internal static void Validate(object value)
    {
        if (value is InteractionResponse response)
        {
            var data = response.Data.GetValueOrDefault(null!);

            var valid = response.Type switch
            {
                InteractionCallbackType.ChannelMessageWithSource or InteractionCallbackType.UpdateMessage =>
                    data is InteractionMessageData,
                InteractionCallbackType.DeferredChannelMessageWithSource => data is null or InteractionMessageData,
                InteractionCallbackType.ApplicationCommandAutocompleteResult => data is InteractionAutocompleteData,
                InteractionCallbackType.Modal => data is InteractionModalData,
                InteractionCallbackType.Pong or InteractionCallbackType.DeferredUpdateMessage
                    or InteractionCallbackType.PremiumRequired
                    or InteractionCallbackType.LaunchActivity => data is null,
                _ => true
            };

            if (!valid)
            {
                throw new InvalidOperationException("Callback type and response data do not match.");
            }
        }

        if (value is Button button)
        {
            var valid = button.Style switch
            {
                ButtonStyle.Link => button.Url.HasValue && !button.CustomId.HasValue && !button.SkuId.HasValue,
                ButtonStyle.Premium => button.SkuId.HasValue && !button.CustomId.HasValue && !button.Url.HasValue,
                _ => button.CustomId.HasValue && !button.Url.HasValue && !button.SkuId.HasValue
            };

            if (!valid)
            {
                throw new InvalidOperationException("Button style and identity fields do not match.");
            }
        }

        if (value is ApplicationCommandOption option && option.Autocomplete.GetValueOrDefault(false) &&
            option.Choices.HasValue)
        {
            throw new InvalidOperationException("Command choices and autocomplete are mutually exclusive.");
        }
    }
}