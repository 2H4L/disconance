using Disconance.Models.Channels;

namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Option data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public class ApplicationCommandOption
{
    /// <summary>
    ///     Type of option.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>type</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required ApplicationCommandOptionType Type { get; set; }

    /// <summary>
    ///     1-32 character name.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Name { get; set; }

    /// <summary>
    ///     Localization dictionary for the <c>name</c> field. Values follow the same restrictions as <c>name</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>name_localizations</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<Dictionary<string, string>?> NameLocalizations { get; set; }

    /// <summary>
    ///     1-100 character description.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required string Description { get; set; }

    /// <summary>
    ///     Localization dictionary for the <c>description</c> field. Values follow the same restrictions as
    ///     <c>description</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>description_localizations</c>. May be omitted. May be null.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<Dictionary<string, string>?> DescriptionLocalizations { get; set; }

    /// <summary>
    ///     Whether the parameter is required or optional, default <c>false</c> .
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>required</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<bool> Required { get; set; }

    /// <summary>
    ///     Choices for the user to pick from, max 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>choices</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<List<ApplicationCommandOptionChoice>> Choices { get; set; }

    /// <summary>
    ///     If the option is a subcommand or subcommand group type, these nested options will be the parameters or
    ///     subcommands respectively; up to 25.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>options</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<List<ApplicationCommandOption>> Options { get; set; }

    /// <summary>
    ///     The channels shown will be restricted to these types.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>channel_types</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<List<ChannelType>> ChannelTypes { get; set; }

    /// <summary>
    ///     The minimum value permitted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_value</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<double> MinValue { get; set; }

    /// <summary>
    ///     The maximum value permitted.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_value</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<double> MaxValue { get; set; }

    /// <summary>
    ///     The minimum allowed length (minimum of <c>0</c> , maximum of <c>6000</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>min_length</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<int> MinLength { get; set; }

    /// <summary>
    ///     The maximum allowed length (minimum of <c>1</c> , maximum of <c>6000</c> ).
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>max_length</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<int> MaxLength { get; set; }

    /// <summary>
    ///     If autocomplete interactions are enabled for this option.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>autocomplete</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public Optional<bool> Autocomplete { get; set; }

    /// <summary>
    ///     File types to filter for; can be <c>image</c> , <c>video</c> , <c>audio</c> , or any dot-prefixed extension
    ///     such as <c>.pdf</c> ; max 10.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>file_types</c>. May be omitted.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    /// <seealso href="https://docs.discord.com/developers/reference#file-type-filtering" />
    public Optional<List<string>> FileTypes { get; set; }
}