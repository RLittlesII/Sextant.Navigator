using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/PageRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.Route{T}" />
    public class PageRoute<T> : Route<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageRoute{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public PageRoute(RouteSettings routeSettings) : base(routeSettings)
        {
        }
    }
}
