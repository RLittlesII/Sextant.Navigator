using System;
using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Linq;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/NavigatorState-class.html
    /// </summary>
    public class NavigatorState
    {
        /// <summary>
        /// Gets the current configuration.
        /// </summary>
        public INavigator Navigator => default(INavigator);

        /// <summary>
        /// Determines whether this instance can pop.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can pop; otherwise, <c>false</c>.
        /// </returns>
        public bool CanPop() => true;

        /// <summary>
        /// Users the gesutre.
        /// </summary>
        /// <returns>A signal.</returns>
        public IObservable<Unit> UserGesutre() => Observable.Return(Unit.Default);

        /// <summary>
        /// Complete the lifecycle for a route that has been popped off the navigator.
        /// </summary>
        /// <param name="route">The route.</param>
        public void FinalizeRoute(Route route) { }

        /// <summary>
        /// Called when this object is inserted into the tree
        /// </summary>
        public void InitializeState() { }

        /// <summary>
        /// Pop the top-most route off the navigator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IObservable<T> Pop<T>() => Observable.Return(default(T));

        /// <summary>
        /// Pop the current route off the navigator and push a named route in its place.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IObservable<T> PopAndPushNamed<T>(string routeName, object argument) => Observable.Return(default(T));

        /// <summary>
        /// Calls pop repeatedly until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IObservable<T> PopUntil<T>(Expression<Func<bool>> predicate) => Observable.Return(default(T));

        /// <summary>
        /// Push the given route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> Push<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IObservable<T> PushAndRemoveUntil<T>(Route<T> route, Expression<Func<bool>> predicate) => Observable.Return(default(T));

        /// <summary>
        /// Push a named route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushNamed<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushNamedAndRemoveUntil<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushReplacement<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushReplacementNamed<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Immediately remove route from the navigator, and Route.dispose it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> RemoveRoute<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> RemoveRouteBelow<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Replaces a route on the navigator with a new route.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> Replace<T>(Route<T> route) => Observable.Return(default(T));

        /// <summary>
        /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> ReplaceRouteBelow<T>(Route<T> route) => Observable.Return(default(T));
    }
}