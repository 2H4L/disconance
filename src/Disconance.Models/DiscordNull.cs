namespace Disconance.Models;

/// <summary>
///     The literal null marker used by Discord's presence-only role tags.
/// </summary>
/// <remarks>
///     A present <c>Optional&lt;DiscordNull&gt;</c> represents JSON null; an absent value represents a missing key.
/// </remarks>
/// <seealso href="https://docs.discord.com/developers/topics/permissions#role-object-role-tags-structure" />
public readonly record struct DiscordNull;