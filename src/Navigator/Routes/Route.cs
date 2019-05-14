using System;
using System.Reactive;
using System.Reactive.Linq;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/Route-class.html
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public Route(RouteSettings routeSettings)
        {
        }

        /// <summary>
        /// Determines whether this route is on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsActive() => Observable.Return(true);
        /// <summary>
        /// Determines whether this route is the top-most route on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsCurrent() => Observable.Return(true);
        /// <summary>
        /// Determines whether this route is the bottom-most route on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsFirst() => Observable.Return(true);

        /// <summary>
        /// Gets the navigator that the route is in, if any.
        /// </summary>
        public NavigatorState Navigator { get; }

        /// <summary>
        /// Gets a future that completes when this route is popped off the navigator.
        /// </summary>
        public IObservable<Unit> Popped { get; }

        /// <summary>
        /// Gets or sets the settings for this route.
        /// </summary>
        public RouteSettings Settings { get; set; }

        /// <summary>
        /// Changeds the state of the external.
        /// </summary>
        void ChangedExternalState() { }

        /// <summary>
        /// Changeds the state of the internal.
        /// </summary>
        void ChangedInternalState() { }

        /// <summary>
        /// Dids the change next.
        /// </summary>
        /// <param name="route">The route.</param>
        void DidChangeNext(Route route) { }
    }

    public class Route<T> : Route
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public Route(RouteSettings routeSettings)
            : base(routeSettings)
        {
        }
    }
}
