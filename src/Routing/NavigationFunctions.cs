namespace Routing;

/// <summary>
/// Initializes <see cref="IInitializable"/> objects.
/// </summary>
internal static class NavigationFunctions
{
    /// <summary>
    /// Initialize the object.
    /// </summary>
    /// <param name="viewModel">The view model.</param>
    /// <param name="navigationParameter">The navigation parameter.</param>
    public static void Initialize(object? viewModel, INavigationParameter? navigationParameter = null)
    {
        navigationParameter ??= new NavigationParameter();

        InvokeAction<IInitializable>(viewModel, initialize =>
        {
            using var _ = initialize.Initializing(navigationParameter).Subscribe();
        });
    }

    public static void OnNavigatedTo(object? viewModel, INavigationParameter? navigationParameter = null)
    {
        navigationParameter ??= new NavigationParameter();

        InvokeAction<INavigable>(viewModel, navigable =>
        {
            using var _ = navigable.NavigatedTo(navigationParameter).Subscribe();
        });
    }

    public static void InvokeAction<T>(object? route, Action<T> action)
    {
        if (route is T routeAsType)
        {
            action.Invoke(routeAsType);
        }
    }
}