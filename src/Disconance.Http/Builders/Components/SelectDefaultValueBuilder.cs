using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes SelectDefaultValue values. Discord limits are documented on the model.
/// </summary>
public sealed class SelectDefaultValueBuilder : ModelBuilder<SelectDefaultValue, SelectDefaultValueBuilder>
{
    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public SelectDefaultValueBuilder WithId(Snowflake value)
    {
        return Set("Id", value);
    }

    /// <summary>
    ///     Sets Type; explicit values, including defaults, remain present.
    /// </summary>
    public SelectDefaultValueBuilder WithType(string value)
    {
        return Set("Type", value);
    }
}