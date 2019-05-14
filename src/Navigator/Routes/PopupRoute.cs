using System;
using System.Collections.Generic;
using System.Text;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/PopupRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.ModalRoute{T}" />
    public class PopupRoute<T> : ModalRoute<T>
    {
        public PopupRoute(RouteSettings routeSettings) : base(routeSettings)
        {
        }
    }
}
