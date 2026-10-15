using System.Reflection;
using System.Runtime.CompilerServices;
using Disconance.Models;

namespace Disconance.Http.Builders;

/// <summary>
///     Shared state and snapshot behavior for mutable, non-thread-safe model builders.
/// </summary>
/// <typeparam name="T">
///     The model type.
/// </typeparam>
/// <typeparam name="TSelf">
///     The concrete builder type.
/// </typeparam>
public abstract class ModelBuilder<T, TSelf> : IModelBuilder<T> where T : class where TSelf : ModelBuilder<T, TSelf>
{
    private readonly HashSet<string> _assigned = [];
    private readonly T _value = Activator.CreateInstance<T>();

    /// <summary>
    ///     Builds an independent snapshot after checking required values.
    /// </summary>
    public virtual T Build()
    {
        foreach (var property in typeof(T).GetProperties())
        {
            if (property.IsDefined(typeof(RequiredMemberAttribute)) &&
                (!_assigned.Contains(property.Name) || property.GetValue(_value) is null))
            {
                throw new InvalidOperationException($"{typeof(T).Name}.{property.Name} is required.");
            }
        }

        CompositionValidation.Validate(_value);
        return ModelSnapshot.Copy(_value);
    }

    /// <summary>
    ///     Assigns a property and marks it present.
    /// </summary>
    protected TSelf Set<TValue>(string property, TValue value)
    {
        typeof(T).GetProperty(property)!.SetValue(_value, value);
        _assigned.Add(property);
        return (TSelf) this;
    }

    /// <summary>
    ///     Appends to an optional collection.
    /// </summary>
    protected TSelf Add<TItem>(string property, TItem value)
    {
        var member = typeof(T).GetProperty(property)!;
        var current = member.GetValue(_value);
        List<TItem> list;

        if (member.PropertyType == typeof(Optional<List<TItem>>))
        {
            var optional = (Optional<List<TItem>>) current!;
            list = optional.HasValue ? optional.Value ?? [] : [];
            list.Add(value);
            return Set(property, new Optional<List<TItem>>(list));
        }

        list = (List<TItem>?) current ?? [];
        list.Add(value);
        return Set(property, list);
    }
}