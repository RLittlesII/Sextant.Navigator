
namespace Sextant.Navigator
{

    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/RouteFactory.html
    /// </summary>
    public delegate Route RouteFactory(RouteSettings routeSettings);

    public static class RouteFactoryExtensions
    {
        /// <summary>
        /// Gets the route.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="routeFactory">The route factory.</param>
        /// <param name="routeSettings">The route settings.</param>
        /// <returns>The route.</returns>
        public static T GetRoute<T>(this RouteFactory routeFactory, RouteSettings routeSettings)
            where T : Route => (T) routeFactory(routeSettings);
    }
}