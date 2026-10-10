using Disconance.Models.Channels;

namespace Disconance.Models.Components;

/// <summary>
///     Channel Select data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
public class ChannelSelect : Component
{
    /// <summary>
    ///     <c>8</c> for channel select.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public override ComponentType Type => ComponentType.ChannelSelect;

    /// <summary>
    ///     ID for the select menu; 1-100 characters.
    /// </summary>
    /// <remarks>Discord field: <c>custom_id</c>.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public required string CustomId { get; set; }

    /// <summary>
    ///     List of channel types to include in the channel select component.
    /// </summary>
    /// <remarks>Discord field: <c>channel_types</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<List<ChannelType>> ChannelTypes { get; set; }

    /// <summary>
    ///     Placeholder text if nothing is selected; max 150 characters.
    /// </summary>
    /// <remarks>Discord field: <c>placeholder</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<string> Placeholder { get; set; }

    /// <summary>
    ///     List of default values for auto-populated select menu components; number of default values must be in the
    ///     range defined by <c>min_values</c> and <c>max_values</c> .
    /// </summary>
    /// <remarks>Discord field: <c>default_values</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<List<SelectDefaultValue>> DefaultValues { get; set; }

    /// <summary>
    ///     Minimum number of items that must be chosen (defaults to 1); min 0 (see note), max 25.
    /// </summary>
    /// <remarks>Discord field: <c>min_values</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<int> MinValues { get; set; }

    /// <summary>
    ///     Maximum number of items that can be chosen (defaults to 1); max 25.
    /// </summary>
    /// <remarks>Discord field: <c>max_values</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<int> MaxValues { get; set; }

    /// <summary>
    ///     Whether the channel select is required to answer in a modal (defaults to <c>true</c> ).
    /// </summary>
    /// <remarks>Discord field: <c>required</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     Whether select menu is disabled in a message (defaults to <c>false</c> ).
    /// </summary>
    /// <remarks>Discord field: <c>disabled</c>. May be omitted.</remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/components/reference#channel-select-channel-select-structure" />
    public Optional<bool> Disabled { get; set; }
}