namespace Disconance.Models.Invites;

/// <summary>
///     Invite Metadata data defined by Discord.
/// </summary>
/// <seealso
///     href="https://docs.discord.com/developers/resources/invite#invite-metadata-object-invite-metadata-structure" />
public class InviteMetadata : Invite
{
    /// <summary>
    ///     Number of times this invite has been used.
    /// </summary>
    /// <remarks>Discord field: <c>uses</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-metadata-object" />
    public required int Uses { get; set; }

    /// <summary>
    ///     Max number of times this invite can be used.
    /// </summary>
    /// <remarks>Discord field: <c>max_uses</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-metadata-object" />
    public required int MaxUses { get; set; }

    /// <summary>
    ///     Duration (in seconds) after which the invite expires.
    /// </summary>
    /// <remarks>Discord field: <c>max_age</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-metadata-object" />
    public required int MaxAge { get; set; }

    /// <summary>
    ///     Whether this invite only grants temporary membership.
    /// </summary>
    /// <remarks>Discord field: <c>temporary</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-metadata-object" />
    public required bool Temporary { get; set; }

    /// <summary>
    ///     When this invite was created.
    /// </summary>
    /// <remarks>Discord field: <c>created_at</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/invite#invite-metadata-object" />
    public required DateTimeOffset CreatedAt { get; set; }
}