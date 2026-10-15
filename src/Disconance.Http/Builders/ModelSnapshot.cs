using System.Collections;
using System.Reflection;
using System.Text.Json;
using Disconance.Models;

namespace Disconance.Http.Builders;

/// <summary>
///     Copies supported model graphs without changing their optional or scalar variants.
/// </summary>
internal static class ModelSnapshot
{
    /// <summary>
    ///     Copies models, optional values, lists and dictionaries; immutable scalar values are retained.
    /// </summary>
    public static T Copy<T>(T value)
    {
        return (T) CopyValue(value, new Dictionary<object, object>(ReferenceEqualityComparer.Instance))!;
    }

    private static object? CopyValue(object? value, Dictionary<object, object> seen)
    {
        if (value is null)
        {
            return null;
        }

        var type = value.GetType();

        if (type.IsPrimitive || type.IsEnum || value is string or decimal or DateTimeOffset or DateTime or TimeSpan
                or Guid or Uri or Snowflake or DiscordNull)
        {
            return value;
        }

        if (seen.TryGetValue(value, out var existing))
        {
            return existing;
        }

        if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Optional<>))
        {
            return (bool) type.GetProperty("HasValue")!.GetValue(value)!
                ? Activator.CreateInstance(type, CopyValue(type.GetProperty("Value")!.GetValue(value), seen))
                : Activator.CreateInstance(type);
        }

        if (value is Array array)
        {
            var copy = Array.CreateInstance(type.GetElementType()!, array.Length);
            seen[value] = copy;

            for (var i = 0; i < array.Length; i++)
            {
                copy.SetValue(CopyValue(array.GetValue(i), seen), i);
            }

            return copy;
        }

        if (value is IDictionary dictionary)
        {
            var copy = (IDictionary) Activator.CreateInstance(type)!;
            seen[value] = copy;

            foreach (DictionaryEntry item in dictionary)
            {
                copy.Add(CopyValue(item.Key, seen)!, CopyValue(item.Value, seen));
            }

            return copy;
        }

        if (value is IList list)
        {
            var copy = (IList) Activator.CreateInstance(type)!;
            seen[value] = copy;

            foreach (var item in list)
            {
                copy.Add(CopyValue(item, seen));
            }

            return copy;
        }

        if (value is JsonElement element)
        {
            return element.Clone();
        }

        if (type.Namespace?.StartsWith("Disconance.", StringComparison.Ordinal) != true)
        {
            throw new NotSupportedException($"Snapshotting {type.Name} is not supported.");
        }

        var clone =
            typeof(object).GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic)!.Invoke(value,
                null)!;

        seen[value] = clone;

        foreach (var field in Fields(type))
        {
            field.SetValue(clone, CopyValue(field.GetValue(value), seen));
        }

        return clone;
    }

    private static IEnumerable<FieldInfo> Fields(Type type)
    {
        for (var current = type; current is not null; current = current.BaseType)
        {
            foreach (var field in current.GetFields(BindingFlags.Instance | BindingFlags.Public |
                                                    BindingFlags.NonPublic | BindingFlags.DeclaredOnly))
            {
                yield return field;
            }
        }
    }
}