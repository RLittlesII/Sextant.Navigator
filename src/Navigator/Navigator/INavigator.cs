using System;
using System.Linq.Expressions;
using System.Reactive.Linq;

namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/Navigator-class.html
    /// </summary>
    public interface INavigator
    {
        /// <summary>
        /// Gets or sets the on generate route.
        /// </summary>
        RouteFactory OnGenerateRoute { get; set; }

        /// <summary>
        /// Determines whether this instance can pop the specified context.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <returns>
        ///   <c>true</c> if this instance can pop the specified context; otherwise, <c>false</c>.
        /// </returns>
        bool CanPop(INavigationContext context);

        /// <summary>
        /// Returns the value of the current route's Route.willPop method for the navigator that most tightly encloses the given context.
        /// </summary>
        /// <typeparam name="TResult">The type of the result.</typeparam>
        /// <param name="context">The context.</param>
        /// <returns></returns>
        IObservable<bool> MaybePop<TResult>(INavigationContext context)
            where TResult : class;

        /// <summary>
        /// Pop the top-most route off the navigator
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IObservable<T> Pop<T>()
            where T : class;

        /// <summary>
        /// Pop the current route off the navigator and push a named route in its place.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        IObservable<T> PopAndPushNamed<T>(string routeName, object argument);

        /// <summary>
        /// Calls pop repeatedly until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IObservable<T> PopUntil<T>(Expression<Func<Route, bool>> predicate);

        /// <summary>
        /// Push the given route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> Push<T>(Route<T> route);

        /// <summary>
        /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <param name="predicate">The predicate.</param>
        /// <returns></returns>
        IObservable<T> PushAndRemoveUntil<T>(Route<T> route, Expression<Func<bool>> predicate);

        /// <summary>
        /// Push a named route onto the navigator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> PushNamed<T>(Route<T> route);

        /// <summary>
        /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> PushNamedAndRemoveUntil<T>(Route<T> route);

        /// <summary>
        /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> PushReplacement<T>(Route<T> route);

        /// <summary>
        /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> PushReplacementNamed<T>(Route<T> route);

        /// <summary>
        /// Immediately remove route from the navigator, and Route.dispose it.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> RemoveRoute<T>(Route<T> route);

        /// <summary>
        /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> RemoveRouteBelow<T>(Route<T> route);

        /// <summary>
        /// Replaces a route on the navigator with a new route.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> Replace<T>(Route<T> route);

        /// <summary>
        /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="route">The route.</param>
        /// <returns></returns>
        IObservable<T> ReplaceRouteBelow<T>(Route<T> route);
    }
}
