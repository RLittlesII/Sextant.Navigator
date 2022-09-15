namespace Routing;

/// <summary>
/// Interface representing a parameter passed during navigation.
/// </summary>
public interface INavigationParameter : IDictionary<string, object>
{
    /// <summary>
    /// Gets the value from the navigation parameter.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <typeparam name="T">The type parameter.</typeparam>
    /// <returns>The value.</returns>
    T GetValue<T>(string key);

    /// <summary>
    /// Gets the value from the navigation parameter with the specified key.
    /// </summary>
    /// <param name="key">The key.</param>
    /// <param name="value">The value.</param>
    /// <typeparam name="T">The type of the parameter.</typeparam>
    /// <returns>A value indicating whether the value exists.</returns>
    bool TryGetValue<T>(string key, out T value);
}