namespace Disconance.Models.Messages;

/// <summary>
///     Known Discord allowed mention types. String properties also accept values added by Discord in the future.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/message#allowed-mentions-object-allowed-mention-types" />
public static class AllowedMentionType
{
    /// <summary>
    ///     Controls role mentions.
    /// </summary>
    public const string Roles = "roles";

    /// <summary>
    ///     Controls user mentions.
    /// </summary>
    public const string Users = "users";

    /// <summary>
    ///     Controls @everyone and @here mentions.
    /// </summary>
    public const string Everyone = "everyone";
}