using System.Linq.Expressions;
using System.Reactive;
using Navigator.Routes;

namespace Navigator;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/Navigator-class.html.
/// </summary>
// QUESTION: [rlittlesii: August 13, 2022] Implement me on each platform?!
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
    RouteFactory? OnGenerateRoute { get; set; }

    /// <summary>
    /// Gets or sets the pop page call back.
    /// </summary>
    PopPageCallback? OnPopPage { get; set; }

    /// <summary>
    /// Gets the list of pages.  Future: this should be the platforms page.
    /// </summary>
    List<string> Pages { get; }

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
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> Pop<TRoute>()
        where TRoute : Route;

    /// <summary>
    /// Pop the current route off the navigator and push a named route in its place.
    /// </summary>
    /// <param name="routeName">The route name.</param>
    /// <param name="argument">The argument.</param>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PopAndPushNamed<TRoute>(string routeName, object argument)
        where TRoute : Route;

    /// <summary>
    /// Calls pop repeatedly until the predicate returns true.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PopUntil<TRoute>(Expression<Func<TRoute, bool>> predicate)
        where TRoute : Route;

    /// <summary>
    /// Push the given route onto the navigator.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> Push<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PushAndRemoveUntil<TRoute>(TRoute route, Expression<Func<TRoute, bool>> predicate)
        where TRoute : Route;

    /// <summary>
    /// Push a named route onto the navigator.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PushNamed<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PushNamedAndRemoveUntil<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PushReplacement<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> PushReplacementNamed<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Immediately remove route from the navigator, and Route.dispose it.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> RemoveRoute<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> RemoveRouteBelow<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Replaces a route on the navigator with a new route.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> Replace<TRoute>(TRoute route)
        where TRoute : Route;

    /// <summary>
    /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="TRoute">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    IObservable<TRoute> ReplaceRouteBelow<TRoute>(TRoute route)
        where TRoute : Route;
}