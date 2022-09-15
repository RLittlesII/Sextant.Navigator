namespace Routing;

/// <summary>
/// Initializes <see cref="IInitializable"/> objects.
/// </summary>
public static class NavigationFunctions
{
    /// <summary>
    /// Initialize the object.
    /// </summary>
    /// <param name="viewModel">The view model.</param>
    public static void Initialize(object? viewModel)
    {
        if (viewModel is IInitializable { } initialize)
        {
            using var _ = initialize.Initializing(new NavigationParameter()).Subscribe();
        }
    }
}