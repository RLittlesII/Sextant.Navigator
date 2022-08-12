namespace Navigator.Routes;

public static class RouteFactoryExtensions
{
    /// <summary>
    /// Gets the route from the route factory.
    /// </summary>
    /// <param name="routeFactory"></param>
    /// <param name="routeSettings"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T GetRoute<T>(this RouteFactory routeFactory, RouteSettings routeSettings)
        where T : Route => (T)routeFactory(routeSettings);
}