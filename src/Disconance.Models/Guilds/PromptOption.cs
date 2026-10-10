using Disconance.Models.Emojis;

namespace Disconance.Models.Guilds;

/// <summary>
///     Prompt Option data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object-prompt-option-structure" />
public class PromptOption
{
    /// <summary>
    ///     ID of the prompt option.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required Snowflake Id { get; set; }

    /// <summary>
    ///     IDs for channels a member is added to when the option is selected.
    /// </summary>
    /// <remarks>Discord field: <c>channel_ids</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required List<Snowflake> ChannelIds { get; set; }

    /// <summary>
    ///     IDs for roles assigned to a member when the option is selected.
    /// </summary>
    /// <remarks>Discord field: <c>role_ids</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    /// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object" />
    public required List<Snowflake> RoleIds { get; set; }

    /// <summary>
    ///     Emoji of the option (see below).
    /// </summary>
    /// <remarks>Discord field: <c>emoji</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public Optional<Emoji> Emoji { get; set; }

    /// <summary>
    ///     Emoji ID of the option (see below).
    /// </summary>
    /// <remarks>Discord field: <c>emoji_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public Optional<Snowflake> EmojiId { get; set; }

    /// <summary>
    ///     Emoji name of the option (see below).
    /// </summary>
    /// <remarks>Discord field: <c>emoji_name</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public Optional<string> EmojiName { get; set; }

    /// <summary>
    ///     Whether the emoji is animated (see below).
    /// </summary>
    /// <remarks>Discord field: <c>emoji_animated</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public Optional<bool> EmojiAnimated { get; set; }

    /// <summary>
    ///     Title of the option.
    /// </summary>
    /// <remarks>Discord field: <c>title</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required string Title { get; set; }

    /// <summary>
    ///     Description of the option.
    /// </summary>
    /// <remarks>Discord field: <c>description</c>. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required string? Description { get; set; }
}