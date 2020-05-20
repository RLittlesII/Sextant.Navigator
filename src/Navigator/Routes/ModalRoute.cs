using System;

namespace Sextant.Navigator
{
    public class ModalRoute : TransitionRoute
    {
        public ModalRoute(RouteSettings routeSettings)
            : base(routeSettings)
        {
        }

        public void AddScopedWillPopCallback(Action callback) => callback?.Invoke();
    }

    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/ModalRoute-class.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Navigator.TransitionRoute{T}" />
    public class ModalRoute<T> : ModalRoute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalRoute{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public ModalRoute(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }
    }
}
