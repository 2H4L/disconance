using Disconance.Models.Guilds;

namespace Disconance.Models.Users;

/// <summary>
///     Connection data defined by Discord.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
public class Connection
{
    /// <summary>
    ///     Id of the connection account.
    /// </summary>
    /// <remarks>Discord field: <c>id</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required string Id { get; set; }

    /// <summary>
    ///     The username of the connection account.
    /// </summary>
    /// <remarks>Discord field: <c>name</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required string Name { get; set; }

    /// <summary>
    ///     The service of this connection.
    /// </summary>
    /// <remarks>Discord field: <c>type</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required string Type { get; set; }

    /// <summary>
    ///     Whether the connection is revoked.
    /// </summary>
    /// <remarks>Discord field: <c>revoked</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public Optional<bool> Revoked { get; set; }

    /// <summary>
    ///     An array of partial server integrations.
    /// </summary>
    /// <remarks>Discord field: <c>integrations</c>. May be omitted.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    /// <seealso href="https://docs.discord.com/developers/resources/guild#integration-object" />
    public Optional<List<PartialIntegration>> Integrations { get; set; }

    /// <summary>
    ///     Whether the connection is verified.
    /// </summary>
    /// <remarks>Discord field: <c>verified</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required bool Verified { get; set; }

    /// <summary>
    ///     Whether friend sync is enabled for this connection.
    /// </summary>
    /// <remarks>Discord field: <c>friend_sync</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required bool FriendSync { get; set; }

    /// <summary>
    ///     Whether activities related to this connection will be shown in presence updates.
    /// </summary>
    /// <remarks>Discord field: <c>show_activity</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required bool ShowActivity { get; set; }

    /// <summary>
    ///     Whether this connection has a corresponding third party OAuth2 token.
    /// </summary>
    /// <remarks>Discord field: <c>two_way_link</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required bool TwoWayLink { get; set; }

    /// <summary>
    ///     Visibility of this connection.
    /// </summary>
    /// <remarks>Discord field: <c>visibility</c>.</remarks>
    /// <seealso href="https://docs.discord.com/developers/resources/user#connection-object-connection-structure" />
    public required ConnectionVisibilityType Visibility { get; set; }
}