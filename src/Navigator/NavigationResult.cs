namespace Navigator;

/// <summary>
/// Represents the completion state of a navigation.
/// </summary>
public class NavigationResult : EventArgs
{
    /// <summary>
    /// Gets a value indicating whether the navigation was a success.
    /// </summary>
    public bool Success { get; }

    /// <summary>
    /// Gets the exception produced during navigation.
    /// </summary>
    public Exception? Exception { get; }
}