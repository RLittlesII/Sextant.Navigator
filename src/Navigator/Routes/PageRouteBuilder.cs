using System;
using System.Diagnostics.CodeAnalysis;

namespace Sextant.Navigator
{
    public class PageRouteBuilder<T> : PageRoute<T>
    {
        public RoutePageBuilder PageBuilder { get; private set; }

        public RouteTransitionsBuilder RouteTransitionsBuilder { get; private set; }

        public bool Opaque { get; private set; }

        public bool BarrierDismissible { get; private set; }

        public bool FullscreenDialog { get; private set; }

        public bool MaintainState { get; set; }

        public PageRouteBuilder(RouteSettings<T> routeSettings,
            [NotNull] RoutePageBuilder pageBuilder,
            [MaybeNull] RouteTransitionsBuilder routeTransitionsBuilder,
            double transitionDuration = 300,
            bool opaque = true,
            bool barrierDismissible = false,
            bool maintainState = true,
            bool fullscreenDialog = false)
            : base(routeSettings)
        {
            PageBuilder = pageBuilder;
            RouteTransitionsBuilder = routeTransitionsBuilder;
            TransitionDuration = transitionDuration;
            Opaque = opaque;
            BarrierDismissible = barrierDismissible;
            FullscreenDialog = fullscreenDialog;
            MaintainState = maintainState;
        }

        /// <summary>
        /// Override this method to build the primary content of this route.
        /// </summary>
        /// <param name="animation">The primary animation.</param>
        /// <param name="secondaryAnimation">The secondary animation.</param>
        /// <typeparam name="T">The type to build.</typeparam>
        /// <returns>The built instance.</returns>
        public virtual T BuildPage(Animation<double> animation, Animation<double> secondaryAnimation)
        {
            return default(T);
        }

        /// <summary>
        /// Override this method to wrap the child with one or more transition widgets that define how the route arrives on and leaves the screen.
        /// </summary>
        /// <param name="animation">The primary animation.</param>
        /// <param name="secondaryAnimation">The secondary animation.</param>
        /// <typeparam name="T">The type to build.</typeparam>
        /// <returns>The built instance.</returns>
        public virtual T BuildTransition(Animation<double> animation, Animation<double> secondaryAnimation)
        {
            return default(T);
        }
    }

    /// <summary>
    /// Signature for the function that builds a route's primary contents. Used in PageRouteBuilder and showGeneralDialog.
    /// </summary>
    /// <remarks>https://api.flutter.dev/flutter/widgets/RoutePageBuilder.html</remarks>
    public class RoutePageBuilder
    {
    }

    /// <summary>
    /// Signature for the function that builds a route's transitions. Used in PageRouteBuilder and showGeneralDialog.
    /// </summary>
    /// <remarks>https://api.flutter.dev/flutter/widgets/RouteTransitionsBuilder.html</remarks>
    public class RouteTransitionsBuilder
    {
    }
}