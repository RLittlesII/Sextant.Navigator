using System.Reflection;

namespace Routing;

/// <summary>
/// Enumeration Class.
/// </summary>
/// <typeparam name="T">The value type.</typeparam>
public abstract class Enumeration<T> : IComparable<T>, IComparable
    where T : IComparable, IComparable<T>, IConvertible, IEquatable<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Enumeration{T}"/> class.
    /// </summary>
    protected Enumeration()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Enumeration{T}"/> class.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <param name="displayName">The display name.</param>
    protected Enumeration(T value, string displayName)
    {
        Value = value;
        DisplayName = displayName;
    }

    /// <summary>
    /// Gets the value.
    /// </summary>
    public T Value { get; }

    /// <summary>
    /// Gets the display name.
    /// </summary>
    public string DisplayName { get; }

    /// <summary>
    /// Enumerate the <see cref="TEnumeration"/>.
    /// </summary>
    /// <typeparam name="TEnumeration">The enumeration type.</typeparam>
    /// <returns>The enumerated enumeration.</returns>
    public static IEnumerable<TEnumeration> GetAll<TEnumeration>()
        where TEnumeration : Enumeration<T>, new()
    {
        var type = typeof(T);
        var fields = type.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly);

        foreach (var info in fields)
        {
            var instance = new TEnumeration();
            var locatedValue = info.GetValue(instance) as TEnumeration;

            if (locatedValue != null)
            {
                yield return locatedValue;
            }
        }
    }

    /// <summary>
    /// Gets the <see cref="TEnumeration"/> from the value.
    /// </summary>
    /// <param name="value">The value.</param>
    /// <typeparam name="TEnumeration">The enumeration type.</typeparam>
    /// <returns>The enumeration.</returns>
    public static TEnumeration FromValue<TEnumeration>(T value)
        where TEnumeration : Enumeration<T>, new()
    {
        var matchingItem = Parse<TEnumeration, T>(value, "value", item => item.Value.Equals(value));
        return matchingItem;
    }

    /// <summary>
    /// Gets the <see cref="TEnumeration"/> from the display name.
    /// </summary>
    /// <param name="displayName">The display name.</param>
    /// <typeparam name="TEnumeration">The enumeration type.</typeparam>
    /// <returns>The enumeration.</returns>
    public static TEnumeration FromDisplayName<TEnumeration>(string displayName)
        where TEnumeration : Enumeration<T>, new()
    {
        var matchingItem = Parse<TEnumeration, string>(displayName, "display name", item => item.DisplayName == displayName);
        return matchingItem;
    }

    /// <inheritdoc />
    public override string ToString() => DisplayName;

    /// <inheritdoc />
    public int CompareTo(object other) => Value.CompareTo(((Enumeration<T>)other).Value);

    /// <inheritdoc />
    public int CompareTo(T? other) => Value.CompareTo(other);

    /// <inheritdoc/>
    public override bool Equals(object obj)
    {
        var otherValue = obj as Enumeration<T>;

        if (otherValue == null)
        {
            return false;
        }

        var typeMatches = GetType().Equals(obj.GetType());
        var valueMatches = Value.Equals(otherValue.Value);

        return typeMatches && valueMatches;
    }

    /// <inheritdoc/>
    public override int GetHashCode() => Value.GetHashCode();

    private static TEnumeration Parse<TEnumeration, TValue>(TValue value, string description, Func<TEnumeration, bool> predicate)
        where TEnumeration : Enumeration<T>, new()
    {
        var matchingItem = GetAll<TEnumeration>().FirstOrDefault(predicate);

        if (matchingItem == null)
        {
            var message = string.Format("'{0}' is not a valid {1} in {2}", value, description, typeof(TEnumeration));
            throw new ApplicationException(message);
        }

        return matchingItem;
    }
}