namespace Disconance.Models.Channels;

/// <summary>
///     The entity targeted by a channel permission overwrite.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/channel#overwrite-object-overwrite-structure" />
public enum OverwriteType
{
    /// <summary>
    ///     A role.
    /// </summary>
    Role = 0,

    /// <summary>
    ///     A guild member.
    /// </summary>
    Member = 1
}