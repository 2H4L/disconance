namespace Disconance.Models.Users;

/// <summary>
///     User Primary Guild data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-primary-guild" />
public class UserPrimaryGuild
{
    /// <summary>
    ///     The id of the user's primary guild.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>identity_guild_id</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-primary-guild" />
    public required Snowflake? IdentityGuildId { get; set; }

    /// <summary>
    ///     Whether the user is displaying the primary guild's server tag. This can be <c>null</c> if the system clears
    ///     the identity, e.g. the server no longer supports tags. This will be <c>false</c> if the user manually
    ///     removes their tag.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>identity_enabled</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-primary-guild" />
    public required bool? IdentityEnabled { get; set; }

    /// <summary>
    ///     The text of the user's server tag. Limited to 4 characters.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>tag</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-primary-guild" />
    public required string? Tag { get; set; }

    /// <summary>
    ///     The server tag badge hash.
    /// </summary>
    /// <remarks>
    ///     Discord field: <c>badge</c>. May be null.
    /// </remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#user-object-user-primary-guild" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required string? Badge { get; set; }
}