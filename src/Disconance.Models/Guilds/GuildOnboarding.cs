namespace Disconance.Models.Guilds;

/// <summary>
///     Guild Onboarding data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object-guild-onboarding-structure" />
public class GuildOnboarding
{
    /// <summary>
    ///     ID of the guild this onboarding is part of.
    /// </summary>
    /// <remarks>Discord field: <c>guild_id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required Snowflake GuildId { get; set; }

    /// <summary>
    ///     Prompts shown during onboarding and in customize community.
    /// </summary>
    /// <remarks>Discord field: <c>prompts</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required List<OnboardingPrompt> Prompts { get; set; }

    /// <summary>
    ///     Channel IDs that members get opted into automatically.
    /// </summary>
    /// <remarks>Discord field: <c>default_channel_ids</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required List<Snowflake> DefaultChannelIds { get; set; }

    /// <summary>
    ///     Whether onboarding is enabled in the guild.
    /// </summary>
    /// <remarks>Discord field: <c>enabled</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required bool Enabled { get; set; }

    /// <summary>
    ///     Current mode of onboarding.
    /// </summary>
    /// <remarks>Discord field: <c>mode</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/guild#guild-onboarding-object" />
    public required OnboardingMode Mode { get; set; }
}