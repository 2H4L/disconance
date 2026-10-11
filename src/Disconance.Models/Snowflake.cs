using System.Globalization;

namespace Disconance.Models;

/// <summary>
///     A Discord identifier preserving the full unsigned 64-bit range.
/// </summary>
/// <remarks>
///     Wire formats normally encode snowflakes as decimal strings. Use the shared DiscordJson configuration.
/// </remarks>
/// <seealso href="https://docs.discord.com/developers/reference#snowflakes" />
public readonly record struct Snowflake(ulong Value) : IComparable<Snowflake>
{
    /// <summary>
    ///     The unsigned identifier value.
    /// </summary>
    public ulong Value { get; init; } = Value;

    /// <summary>
    ///     The timestamp encoded in the identifier, relative to Discord's 2015 epoch.
    /// </summary>
    public DateTimeOffset Timestamp => DateTimeOffset.FromUnixTimeMilliseconds((long)(Value >> 22) + 1420070400000L);

    /// <summary>
    ///     Compares identifiers numerically.
    /// </summary>
    public int CompareTo(Snowflake other)
    {
        return Value.CompareTo(other.Value);
    }

    /// <summary>
    ///     Parses an unsigned decimal identifier without signs or whitespace.
    /// </summary>
    /// <exception cref="FormatException">
    ///     The text is not an unsigned decimal identifier.
    /// </exception>
    /// <exception cref="OverflowException">
    ///     The number exceeds the unsigned 64-bit range.
    /// </exception>
    public static Snowflake Parse(string value)
    {
        return new Snowflake(ulong.Parse(value, NumberStyles.None, CultureInfo.InvariantCulture));
    }

    /// <summary>
    ///     Attempts to parse an unsigned decimal identifier.
    /// </summary>
    public static bool TryParse(string? value, out Snowflake result)
    {
        var success = ulong.TryParse(value, NumberStyles.None, CultureInfo.InvariantCulture, out var parsed);
        result = new Snowflake(parsed);
        return success;
    }

    /// <summary>
    ///     Returns the invariant decimal representation.
    /// </summary>
    public override string ToString()
    {
        return Value.ToString(CultureInfo.InvariantCulture);
    }

    /// <summary>
    ///     Creates an identifier from its unsigned value.
    /// </summary>
    public static implicit operator Snowflake(ulong value)
    {
        return new Snowflake(value);
    }

    /// <summary>
    ///     Extracts the unsigned identifier value.
    /// </summary>
    public static explicit operator ulong(Snowflake value)
    {
        return value.Value;
    }
}