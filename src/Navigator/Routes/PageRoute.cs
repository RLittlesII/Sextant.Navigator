[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Generic type class.")]

namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/PageRoute-class.html.
/// </summary>
public class PageRoute : ModalRoute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PageRoute"/> class.
    /// https://api.flutter.dev/flutter/widgets/PageRoute-class.html.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    public PageRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }
}

/// <summary>
/// https://api.flutter.dev/flutter/widgets/PageRoute-class.html.
/// </summary>
/// <typeparam name="T">The composed type.</typeparam>
public class PageRoute<T> : ModalRoute<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PageRoute{T}"/> class.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    public PageRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }
}