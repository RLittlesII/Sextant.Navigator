
namespace Sextant.Navigator
{

    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/RouteFactory.html
    /// </summary>
    public delegate Route RouteFactory(RouteSettings routeSettings);

    public static class RouteFactoryExtensions
    {
        public static T GetRoute<T>(this RouteFactory routeFactory, RouteSettings routeSettings)
            where T : Route => (T) routeFactory(routeSettings);
    }
}