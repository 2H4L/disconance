namespace Disconance.Models.Activities;

/// <summary>
///     Activity Assets data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
public class ActivityAssets
{
    /// <summary>
    ///     See Activity Asset Image.
    /// </summary>
    /// <remarks>Discord field: <c>large_image</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> LargeImage { get; set; }

    /// <summary>
    ///     Text displayed when hovering over the large image of the activity.
    /// </summary>
    /// <remarks>Discord field: <c>large_text</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> LargeText { get; set; }

    /// <summary>
    ///     URL that is opened when clicking on the large image.
    /// </summary>
    /// <remarks>Discord field: <c>large_url</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> LargeUrl { get; set; }

    /// <summary>
    ///     See Activity Asset Image.
    /// </summary>
    /// <remarks>Discord field: <c>small_image</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> SmallImage { get; set; }

    /// <summary>
    ///     Text displayed when hovering over the small image of the activity.
    /// </summary>
    /// <remarks>Discord field: <c>small_text</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> SmallText { get; set; }

    /// <summary>
    ///     URL that is opened when clicking on the small image.
    /// </summary>
    /// <remarks>Discord field: <c>small_url</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    public Optional<string> SmallUrl { get; set; }

    /// <summary>
    ///     See Activity Asset Image. Displayed as a banner on a Game Invite.
    /// </summary>
    /// <remarks>Discord field: <c>invite_cover_image</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/events/gateway-events#activity-object-activity-assets" />
    /// <seealso
    ///     href="https://docs.discord.com/developers/discord-social-sdk/development-guides/managing-game-invites" />
    public Optional<string> InviteCoverImage { get; set; }
}