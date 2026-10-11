namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     Application Command Option Choice data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public class ApplicationCommandOptionChoice
{
    /// <summary>
    ///     1-100 character choice name.
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
    ///     Value for the choice, up to 100 characters if string.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>value</c>.
    /// </remarks>
    /// <seealso
    ///     href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
    public required CommandChoiceValue Value { get; set; }
}