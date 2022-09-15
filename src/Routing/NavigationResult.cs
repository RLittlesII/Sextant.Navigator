namespace Routing;

/// <summary>
/// Result of a navigation.
/// </summary>
public sealed class NavigationResult : INavigationResult
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NavigationResult"/> class.
    /// </summary>
    /// <param name="succeeded">A value indicating whether the navigation succeeded.</param>
    /// <param name="exception">Thrown exception.</param>
    public NavigationResult(bool succeeded = true, Exception? exception = null)
    {
        Succeeded = succeeded;
        Exception = exception;
    }

    /// <inheritdoc/>
    public bool Succeeded { get; }

    /// <inheritdoc/>
    public Exception? Exception { get; }
}