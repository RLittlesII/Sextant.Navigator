using System;
using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Linq;

namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/NavigatorState-class.html
    /// </summary>
    public class NavigatorState
    {
        private readonly INavigator _navigator;

        public NavigatorState(INavigator navigator)
        {
            _navigator = navigator;
        }

        /// <summary>
        /// Gets the current configuration.
        /// </summary>
        public INavigator Navigator => _navigator;

        /// <summary>
        /// Determines whether this instance can pop.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance can pop; otherwise, <c>false</c>.
        /// </returns>
        public bool CanPop() => true;

        /// <summary>
        /// Users the gesture.
        /// </summary>
        /// <returns>A signal.</returns>
        public IObservable<Unit> UserGesture() => Observable.Return(Unit.Default);

        /// <summary>
        /// Complete the lifecycle for a route that has been popped off the navigator.
        /// </summary>
        /// <param name="route">The route.</param>
        public void FinalizeRoute(Route route)
        {
            route.State.FinalizeRoute(route);
        }

        /// <summary>
        /// Called when this object is inserted into the tree
        /// </summary>
        public void InitializeState() { }

        /// <summary>
        /// Pop the top-most route off the navigator
        /// </summary>
        /// <typeparam name="T">The return type from the router.</typeparam>
        /// <returns></returns>
        public IObservable<T> Pop<T>() where T : Route => _navigator.Pop<T>();

        /// <summary>
        /// Pop the current route off the navigator and push a named route in its place.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public IObservable<T> PopAndPushNamed<T>(string routeName, object argument) where T : Route =>
            _navigator.PopAndPushNamed<T>(routeName, argument);

        /// <summary>
        /// Calls pop repeatedly until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IObservable<T> PopUntil<T>(Expression<Func<T,bool>> predicate) where T : Route =>
            _navigator.PopUntil<T>(predicate);

        /// <summary>
        /// Push the given route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> Push<T>(T route) where T : Route => _navigator.Push(route);

        /// <summary>
        /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        public IObservable<T> PushAndRemoveUntil<T>(T route, Expression<Func<T, bool>> predicate)
            where T : Route => _navigator.PushAndRemoveUntil(route, predicate);

        /// <summary>
        /// Push a named route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushNamed<T>(T route) where T : Route => _navigator.PushNamed(route);

        /// <summary>
        /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushNamedAndRemoveUntil<T>(Route<T> route) =>
            Observable.Return(default(T)).Do(_ => route.DidPop(default(T)));

        /// <summary>
        /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushReplacement<T>(T route) where T : Route => _navigator.PushReplacement(route);

        /// <summary>
        /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> PushReplacementNamed<T>(T route) where T : Route => _navigator.PushReplacementNamed(route);

        /// <summary>
        /// Immediately remove route from the navigator, and Route.dispose it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> RemoveRoute<T>(T route) where T : Route => _navigator.RemoveRoute(route);

        /// <summary>
        /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> RemoveRouteBelow<T>(T route) where T : Route => _navigator.RemoveRouteBelow(route);

        /// <summary>
        /// Replaces a route on the navigator with a new route.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> Replace<T>(T route) where T : Route => _navigator.Replace(route);

        /// <summary>
        /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        public IObservable<T> ReplaceRouteBelow<T>(T route) where T : Route => _navigator.ReplaceRouteBelow(route);
    }
}