using Disconance.Models;
using Disconance.Models.Components;

namespace Disconance.Http.Builders.Components;

/// <summary>
///     Fluently composes Separator values. Discord limits are documented on the model.
/// </summary>
public sealed class SeparatorBuilder : ModelBuilder<Separator, SeparatorBuilder>
{
    /// <summary>
    ///     Sets Divider; explicit values, including defaults, remain present.
    /// </summary>
    public SeparatorBuilder WithDivider(bool value)
    {
        return Set("Divider", new Optional<bool>(value));
    }

    /// <summary>
    ///     Omits Divider from the composition.
    /// </summary>
    public SeparatorBuilder OmitDivider()
    {
        return Set("Divider", default(Optional<bool>));
    }

    /// <summary>
    ///     Sets Spacing; explicit values, including defaults, remain present.
    /// </summary>
    public SeparatorBuilder WithSpacing(SeparatorSpacing value)
    {
        return Set("Spacing", new Optional<SeparatorSpacing>(value));
    }

    /// <summary>
    ///     Omits Spacing from the composition.
    /// </summary>
    public SeparatorBuilder OmitSpacing()
    {
        return Set("Spacing", default(Optional<SeparatorSpacing>));
    }

    /// <summary>
    ///     Sets Id; explicit values, including defaults, remain present.
    /// </summary>
    public SeparatorBuilder WithId(int value)
    {
        return Set("Id", new Optional<int>(value));
    }

    /// <summary>
    ///     Omits Id from the composition.
    /// </summary>
    public SeparatorBuilder OmitId()
    {
        return Set("Id", default(Optional<int>));
    }
}