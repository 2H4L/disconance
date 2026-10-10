using Disconance.Models.Channels;
using Disconance.Models.Guilds;
using Disconance.Models.Messages;
using Disconance.Models.Permissions;
using Disconance.Models.Users;

namespace Disconance.Models.Interactions;

/// <summary>
///     Resolved Data data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public class ResolvedData
{
    /// <summary>
    ///     IDs and User objects.
    /// </summary>
    /// <remarks>Discord field: <c>users</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, User>> Users { get; set; }

    /// <summary>
    ///     IDs and partial Member objects.
    /// </summary>
    /// <remarks>Discord field: <c>members</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, PartialGuildMember>> Members { get; set; }

    /// <summary>
    ///     IDs and Role objects.
    /// </summary>
    /// <remarks>Discord field: <c>roles</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, Role>> Roles { get; set; }

    /// <summary>
    ///     IDs and partial Channel objects.
    /// </summary>
    /// <remarks>Discord field: <c>channels</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, PartialChannel>> Channels { get; set; }

    /// <summary>
    ///     IDs and partial Message objects.
    /// </summary>
    /// <remarks>Discord field: <c>messages</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, PartialMessage>> Messages { get; set; }

    /// <summary>
    ///     IDs and attachment objects.
    /// </summary>
    /// <remarks>Discord field: <c>attachments</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
    public Optional<Dictionary<Snowflake, Attachment>> Attachments { get; set; }
}