namespace Routing;

/// <summary>
/// Represents the result of navigation.
/// </summary>
public interface INavigationResult
{
    /// <summary>
    /// Gets a value indicating whether the result succeeded.
    /// </summary>
    bool Succeeded { get; }

    /// <summary>
    /// Gets an exception if the navigation failed.
    /// </summary>
    Exception? Exception { get; }
}