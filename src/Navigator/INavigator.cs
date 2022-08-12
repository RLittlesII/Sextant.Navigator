using System.Linq.Expressions;
using Navigator.Routes;

namespace Navigator;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/Navigator-class.html.
/// </summary>
public interface INavigator
{
    /// <summary>
    /// Gets the default name of the route.
    /// </summary>
    /// <value>The default name of the route.</value>
    string DefaultRouteName { get; }

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
    /// <param name="context">The context.</param>
    /// <typeparam name="TResult">The type of the result.</typeparam>
    /// <returns>An observable sequence determining whether you can pop.</returns>
    IObservable<bool> MaybePop<TResult>(INavigationContext context)
        where TResult : class;

    /// <summary>
    /// Pop the top-most route off the navigator.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> Pop<T>()
        where T : Route;

    /// <summary>
    /// Pop the current route off the navigator and push a named route in its place.
    /// </summary>
    /// <param name="routeName">The route name.</param>
    /// <param name="argument">The argument.</param>
    /// <typeparam name="T">The route type.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PopAndPushNamed<T>(string routeName, object argument)
        where T : Route;

    /// <summary>
    /// Calls pop repeatedly until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PopUntil<T>(Expression<Func<T, bool>> predicate)
        where T : Route;

    /// <summary>
    /// Push the given route onto the navigator.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> Push<T>(T route)
        where T : Route;

    /// <summary>
    /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PushAndRemoveUntil<T>(T route, Expression<Func<T, bool>> predicate)
        where T : Route;

    /// <summary>
    /// Push a named route onto the navigator.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PushNamed<T>(T route)
        where T : Route;

    /// <summary>
    /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PushNamedAndRemoveUntil<T>(T route)
        where T : Route;

    /// <summary>
    /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PushReplacement<T>(T route)
        where T : Route;

    /// <summary>
    /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> PushReplacementNamed<T>(T route)
        where T : Route;

    /// <summary>
    /// Immediately remove route from the navigator, and Route.dispose it.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> RemoveRoute<T>(T route)
        where T : Route;

    /// <summary>
    /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> RemoveRouteBelow<T>(T route)
        where T : Route;

    /// <summary>
    /// Replaces a route on the navigator with a new route.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> Replace<T>(T route)
        where T : Route;

    /// <summary>
    /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<T> ReplaceRouteBelow<T>(T route)
        where T : Route;
}