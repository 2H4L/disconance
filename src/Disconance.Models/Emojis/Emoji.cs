using Disconance.Models.Users;

namespace Disconance.Models.Emojis;

/// <summary>
///     Emoji data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
public class Emoji
{
    /// <summary>
    ///     Emoji id.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    /// <seealso href="https://docs.discord.com/developers/reference#image-formatting" />
    public required Snowflake? Id { get; set; }

    /// <summary>
    ///     Emoji name.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public required string? Name { get; set; }

    /// <summary>
    ///     Roles allowed to use this emoji.
    /// </summary>
    /// <remarks>Discord field: <c>roles</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<List<Snowflake>> Roles { get; set; }

    /// <summary>
    ///     User that created this emoji.
    /// </summary>
    /// <remarks>Discord field: <c>user</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<User> User { get; set; }

    /// <summary>
    ///     Whether this emoji must be wrapped in colons.
    /// </summary>
    /// <remarks>Discord field: <c>require_colons</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<bool> RequireColons { get; set; }

    /// <summary>
    ///     Whether this emoji is managed.
    /// </summary>
    /// <remarks>Discord field: <c>managed</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<bool> Managed { get; set; }

    /// <summary>
    ///     Whether this emoji is animated.
    /// </summary>
    /// <remarks>Discord field: <c>animated</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<bool> Animated { get; set; }

    /// <summary>
    ///     Whether this emoji can be used, may be false due to loss of Server Boosts.
    /// </summary>
    /// <remarks>Discord field: <c>available</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/emoji#emoji-object-emoji-structure" />
    public Optional<bool> Available { get; set; }
}