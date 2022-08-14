namespace Navigator.Routes;

/// <summary>
/// Methods on top of the <see cref="RouteFactory"/> delegate.
/// </summary>
public static class RouteFactoryExtensions
{
    /// <summary>
    /// Gets the route from the route factory.
    /// </summary>
    /// <param name="routeFactory">The route factory.</param>
    /// <param name="routeSettings">The route settings.</param>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <returns>The route with the settings.</returns>
    public static TRoute GetRoute<TRoute>([NotNull] this RouteFactory routeFactory, RouteSettings routeSettings)
        where TRoute : Route => (TRoute)routeFactory(routeSettings);
}