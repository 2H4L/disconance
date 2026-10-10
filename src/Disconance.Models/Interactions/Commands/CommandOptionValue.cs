namespace Disconance.Models.Interactions.Commands;

/// <summary>
///     A string, integer, number, or boolean supplied as a command option.
/// </summary>
/// <remarks>Snowflake-valued options use the string variant. Integer values retain their full precision.</remarks>
/// <seealso href="https://docs.discord.com/developers/interactions/receiving-and-responding#interaction-object" />
public abstract record CommandOptionValue;

/// <summary>
///     A string, integer, or number used as a command choice.
/// </summary>
/// <seealso href="https://docs.discord.com/developers/interactions/application-commands#application-command-object" />
public abstract record CommandChoiceValue : CommandOptionValue;

/// <summary>
///     A text or snowflake option value.
/// </summary>
/// <param name="Value">The supplied text.</param>
public sealed record StringCommandValue(string Value) : CommandChoiceValue;

/// <summary>
///     An integer option value without floating-point conversion.
/// </summary>
/// <param name="Value">The supplied integer.</param>
public sealed record IntegerCommandValue(long Value) : CommandChoiceValue;

/// <summary>
///     A floating-point option value.
/// </summary>
/// <param name="Value">The supplied number.</param>
public sealed record NumberCommandValue(double Value) : CommandChoiceValue;

/// <summary>
///     A boolean option value. Booleans cannot be command choices.
/// </summary>
/// <param name="Value">The supplied boolean.</param>
public sealed record BooleanCommandValue(bool Value) : CommandOptionValue;