using Disconance.Models;
using Disconance.Models.Messages;

namespace Disconance.Http.Builders.Messages;

/// <summary>
///     Fluently composes AllowedMentions values. Discord limits are documented on the model.
/// </summary>
public sealed class AllowedMentionsBuilder : ModelBuilder<AllowedMentions, AllowedMentionsBuilder>
{
    /// <summary>
    ///     Sets Parse; explicit values, including defaults, remain present.
    /// </summary>
    public AllowedMentionsBuilder WithParse(List<string> value)
    {
        return Set("Parse", new Optional<List<string>>(value));
    }

    /// <summary>
    ///     Omits Parse from the composition.
    /// </summary>
    public AllowedMentionsBuilder OmitParse()
    {
        return Set("Parse", default(Optional<List<string>>));
    }

    /// <summary>
    ///     Appends one Parse.
    /// </summary>
    public AllowedMentionsBuilder AddParse(string value)
    {
        return Add("Parse", value);
    }

    /// <summary>
    ///     Sets Roles; explicit values, including defaults, remain present.
    /// </summary>
    public AllowedMentionsBuilder WithRoles(List<Snowflake> value)
    {
        return Set("Roles", new Optional<List<Snowflake>>(value));
    }

    /// <summary>
    ///     Omits Roles from the composition.
    /// </summary>
    public AllowedMentionsBuilder OmitRoles()
    {
        return Set("Roles", default(Optional<List<Snowflake>>));
    }

    /// <summary>
    ///     Appends one Role.
    /// </summary>
    public AllowedMentionsBuilder AddRole(Snowflake value)
    {
        return Add("Roles", value);
    }

    /// <summary>
    ///     Sets Users; explicit values, including defaults, remain present.
    /// </summary>
    public AllowedMentionsBuilder WithUsers(List<Snowflake> value)
    {
        return Set("Users", new Optional<List<Snowflake>>(value));
    }

    /// <summary>
    ///     Omits Users from the composition.
    /// </summary>
    public AllowedMentionsBuilder OmitUsers()
    {
        return Set("Users", default(Optional<List<Snowflake>>));
    }

    /// <summary>
    ///     Appends one User.
    /// </summary>
    public AllowedMentionsBuilder AddUser(Snowflake value)
    {
        return Add("Users", value);
    }

    /// <summary>
    ///     Sets RepliedUser; explicit values, including defaults, remain present.
    /// </summary>
    public AllowedMentionsBuilder WithRepliedUser(bool value)
    {
        return Set("RepliedUser", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits RepliedUser from the composition.
    /// </summary>
    public AllowedMentionsBuilder OmitRepliedUser()
    {
        return Set("RepliedUser", default(Optional<bool>));
    }
}