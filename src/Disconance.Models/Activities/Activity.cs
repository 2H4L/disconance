namespace Disconance.Models.Activities;

/// <summary>
///     Activity data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
public class Activity
{
    /// <summary>
    ///     Activity's name.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     Activity type.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public required ActivityType Type { get; set; }

    /// <summary>
    ///     Stream URL, is validated when type is 1.
    /// </summary>
    /// <remarks>Discord field: <c>url</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<string?> Url { get; set; }

    /// <summary>
    ///     Unix timestamp (in milliseconds) of when the activity was added to the user's session.
    /// </summary>
    /// <remarks>Discord field: <c>created_at</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public required long CreatedAt { get; set; }

    /// <summary>
    ///     Unix timestamps for start and/or end of the game.
    /// </summary>
    /// <remarks>Discord field: <c>timestamps</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityTimestamps> Timestamps { get; set; }

    /// <summary>
    ///     Application ID for the game.
    /// </summary>
    /// <remarks>Discord field: <c>application_id</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<Snowflake> ApplicationId { get; set; }

    /// <summary>
    ///     Controls which field appears in the user's status text in the member list.
    /// </summary>
    /// <remarks>Discord field: <c>status_display_type</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityStatusDisplayType?> StatusDisplayType { get; set; }

    /// <summary>
    ///     What the player is currently doing.
    /// </summary>
    /// <remarks>Discord field: <c>details</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<string?> Details { get; set; }

    /// <summary>
    ///     URL that is linked when clicking on the details text.
    /// </summary>
    /// <remarks>Discord field: <c>details_url</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<string?> DetailsUrl { get; set; }

    /// <summary>
    ///     User's current party status, or text used for a custom status.
    /// </summary>
    /// <remarks>Discord field: <c>state</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<string?> State { get; set; }

    /// <summary>
    ///     URL that is linked when clicking on the state text.
    /// </summary>
    /// <remarks>Discord field: <c>state_url</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<string?> StateUrl { get; set; }

    /// <summary>
    ///     Emoji used for a custom status.
    /// </summary>
    /// <remarks>Discord field: <c>emoji</c>. May be omitted. May be null.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityEmoji?> Emoji { get; set; }

    /// <summary>
    ///     Information for the current party of the player.
    /// </summary>
    /// <remarks>Discord field: <c>party</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityParty> Party { get; set; }

    /// <summary>
    ///     Images for the presence and their hover texts.
    /// </summary>
    /// <remarks>Discord field: <c>assets</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityAssets> Assets { get; set; }

    /// <summary>
    ///     Secrets for Rich Presence joining and spectating.
    /// </summary>
    /// <remarks>Discord field: <c>secrets</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivitySecrets> Secrets { get; set; }

    /// <summary>
    ///     Whether or not the activity is an instanced game session.
    /// </summary>
    /// <remarks>Discord field: <c>instance</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<bool> Instance { get; set; }

    /// <summary>
    ///     Activity flags <c>OR</c> d together, describes what the payload includes.
    /// </summary>
    /// <remarks>Discord field: <c>flags</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityFlags> Flags { get; set; }

    /// <summary>
    ///     Custom buttons shown in the Rich Presence (max 2).
    /// </summary>
    /// <remarks>Discord field: <c>buttons</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-structure" />
    public Optional<ActivityButtons> Buttons { get; set; }
}