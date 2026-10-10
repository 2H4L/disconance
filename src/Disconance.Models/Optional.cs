namespace Disconance.Models;

/// <summary>
///     A field that can be absent, independently of whether its value can be null.
/// </summary>
/// <typeparam name="T">The field value type. Use a nullable type when Discord permits explicit null.</typeparam>
/// <remarks>
///     The default value represents an absent field. Assigning a value, including null, marks it present.
/// </remarks>
/// <seealso href="https://docs.discord.com/developers/reference#nullable-and-optional-resource-fields" />
public readonly struct Optional<T>
{
    private readonly T _value;

    /// <summary>
    ///     Creates a present field containing the supplied value.
    /// </summary>
    public Optional(T value)
    {
        _value = value;
        HasValue = true;
    }

    /// <summary>
    ///     Whether the field is present, including when its value is null.
    /// </summary>
    public bool HasValue { get; }

    /// <summary>
    ///     The present value.
    /// </summary>
    /// <exception cref="InvalidOperationException">The field is absent.</exception>
    public T Value => HasValue ? _value : throw new InvalidOperationException("The field is absent.");

    /// <summary>
    ///     Returns the present value, or the supplied fallback when absent.
    /// </summary>
    public T GetValueOrDefault(T fallback)
    {
        return HasValue ? _value : fallback;
    }

    /// <summary>
    ///     Creates a present field, including for an explicit null value.
    /// </summary>
    public static implicit operator Optional<T>(T value)
    {
        return new Optional<T>(value);
    }
}