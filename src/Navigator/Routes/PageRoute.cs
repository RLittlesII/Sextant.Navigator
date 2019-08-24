namespace Sextant.Navigator
{
    public class PageRoute : ModalRoute
    {
        public PageRoute(RouteSettings routeSettings)
            : base(routeSettings)
        {
        }
    }

    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/PageRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.Route{T}" />
    public class PageRoute<T> : PageRoute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageRoute{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public PageRoute(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }
    }
}
