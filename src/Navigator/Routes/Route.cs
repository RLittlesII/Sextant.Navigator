using System;
using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Linq;

namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/Route-class.html
    /// </summary>
    public class Route : IDisposable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public Route(RouteSettings routeSettings) { Settings = routeSettings; }

        /// <summary>
        /// Determines whether this route is on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsActive { get; }

        /// <summary>
        /// Determines whether this route is the top-most route on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsCurrent { get; }

        /// <summary>
        /// Determines whether this route is the bottom-most route on the navigator.
        /// </summary>
        /// <returns></returns>
        public IObservable<bool> IsFirst { get; }

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
        public RouteSettings Settings { get; }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Changes the state of the external.
        /// </summary>
        protected void ChangedExternalState() { }

        /// <summary>
        /// Changes the state of the internal.
        /// </summary>
        protected void ChangedInternalState() { }

        /// <summary>
        /// This route's next route has changed to the given new route.
        /// This is called on a route whenever the next route changes for any reason,
        /// so long as it is in the history, including when a route is first added to a Navigator (e.g. by Navigator.push),
        /// except for cases when didPopNext would be called. nextRoute will be null if there's no next route.
        /// </summary>
        /// <param name="route">The route.</param>
        protected virtual void DidChangeNext(Route route) { }

        /// <summary>
        /// This route's previous route has changed to the given new route.
        /// This is called on a route whenever the previous route changes for any reason, so long as it is in the history.
        /// previousRoute will be null if there's no previous route.
        /// </summary>
        /// <param name="route">The route.</param>
        protected  void DidChangePrevious(Route route) { }

        /// <summary>
        /// The route was popped or is otherwise being removed somewhat gracefully.
        /// </summary>
        /// <param name="route">The route.</param>
        protected virtual void DidComplete(Route route) { }

        /// <summary>
        /// A request was made to pop this route.
        /// If the route can handle it internally (e.g. because it has its own stack of internal state) then return false, otherwise return true (by return the value of calling super.didPop).
        /// Returning false will prevent the default behavior of NavigatorState.pop.
        /// </summary>
        /// <typeparam name="T">The result type.</typeparam>
        /// <param name="result">The result.</param>
        protected virtual void DidPop<T>(T result) { }

        /// <summary>
        /// The given route, which was above this one, has been popped off the navigator.
        /// </summary>
        /// <param name="route">The route.</param>
        protected virtual void DidPopNext(Route route) { }

        /// <summary>
        /// Called after install when the route is pushed onto the navigator.
        /// </summary>
        /// <returns>A signal of completion.</returns>
        protected virtual IObservable<Unit> DidPush() => Observable.Return(Unit.Default);

        /// <summary>
        /// Called after install when the route replaced another in the navigator.
        /// </summary>
        /// <param name="route">The route.</param>
        protected virtual void DidReplace(Route route) { }

        /// <summary>
        /// Returns false if this route wants to veto a Navigator.pop.
        /// This method is called by Navigator.maybePop.
        /// </summary>
        /// <returns>An observable of route disposition.</returns>
        public IObservable<RoutePopDisposition> WillPop() => Observable.Return(default(RoutePopDisposition));

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
            }
        }

        public static Expression<Func<T, bool>> WithName<T>(string routeName)
            where T : Route => route => route.Settings.Name == routeName;

    }

    public class Route<T> : Route
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Route{T}"/> class.
        /// </summary>
        /// <param name="routeSettings">The route settings.</param>
        public Route(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }
    }
}
