using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator.Routes
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html
    /// </summary>
    public class TransitionRoute : Route
    {
        public TransitionRoute(RouteSettings routeSettings) : base(routeSettings)
        {
        }
    }

    public class TransitionRoute<T> : Route<T>
    {
        public TransitionRoute(RouteSettings routeSettings) : base(routeSettings)
        {
        }
    }
}
