namespace Disconance.Models.Messages;

/// <summary>
///     A message nonce retaining its string or integer representation.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/resources/message#message-object-message-structure" />
public abstract record MessageNonce;

/// <summary>
///     A textual nonce.
/// </summary>
/// <param name="Value">The nonce text.</param>
public sealed record StringMessageNonce(string Value) : MessageNonce;

/// <summary>
///     An integer nonce.
/// </summary>
/// <param name="Value">The nonce number.</param>
public sealed record IntegerMessageNonce(long Value) : MessageNonce;