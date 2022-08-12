namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/PopupRoute-class.html.
/// </summary>
/// <typeparam name="T">The argument type.</typeparam>
/// <seealso cref="ModalRoute{T}" />
public class PopupRoute<T> : ModalRoute<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PopupRoute{T}"/> class.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    public PopupRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }
}