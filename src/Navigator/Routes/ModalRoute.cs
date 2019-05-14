using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/ModalRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.Route{T}" />
    public class ModalRoute<T> : Route<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalRoute{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public ModalRoute(RouteSettings routeSettings) : base(routeSettings)
        {
        }
    }
}
