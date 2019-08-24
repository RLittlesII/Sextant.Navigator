namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/PopupRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.ModalRoute{T}" />
    public class PopupRoute<T> : PopupRoute
    {
        public PopupRoute(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }
    }

    public class PopupRoute : ModalRoute
    {
        public PopupRoute(RouteSettings routeSettings)
            : base(routeSettings)
        {
        }
    }
}
