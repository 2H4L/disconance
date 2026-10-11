namespace Disconance.Models.Messages;

/// <summary>
///     Default Settings for Allowed Mentions data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
public class AllowedMentions
{
    /// <summary>
    ///     An array of allowed mention types to parse from the content.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>parse</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
    public Optional<List<string>> Parse { get; set; }

    /// <summary>
    ///     Array of role ids to mention, max 100.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>roles</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
    public Optional<List<Snowflake>> Roles { get; set; }

    /// <summary>
    ///     Array of user ids to mention, max 100.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>users</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
    public Optional<List<Snowflake>> Users { get; set; }

    /// <summary>
    ///     For replies, whether to mention the author of the message being replied to, defaults to false.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>replied_user</c>. May be omitted.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/message#allowed-mentions-object" />
    public Optional<bool> RepliedUser { get; set; }
}