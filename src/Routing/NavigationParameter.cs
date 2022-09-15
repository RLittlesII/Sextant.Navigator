using System.Diagnostics.CodeAnalysis;

namespace Routing;

/// <summary>
/// Represents parameters that can be passed during navigation.
/// </summary>
/// <seealso cref="object" />
/// <seealso cref="INavigationParameter" />
[SuppressMessage("Design", "CA1710: Identifiers should have correct suffix.", Justification = "Deliberate usage")]
[SuppressMessage("Design", "CA2237: Mark ISerializable types with SerializableAttribute.", Justification = "Deliberate usage")]
public class NavigationParameter : Dictionary<string, object>, INavigationParameter
{
    /// <inheritdoc />
    public T GetValue<T>(string key) => TryGetValue(key, out T result) ? result : default!;

    /// <inheritdoc />
    public bool TryGetValue<T>(string key, out T value)
    {
        if (TryGetValue(key, out var result))
        {
            value = (T)result;
            return true;
        }

        value = default!;
        return false;
    }
}