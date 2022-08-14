using System.Linq.Expressions;
using System.Reactive;
using System.Reactive.Linq;
using Navigator.Routes;

namespace Navigator;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/NavigatorState-class.html.
/// </summary>
public class NavigatorState
{
    private readonly INavigator _navigator;

    /// <summary>
    /// Initializes a new instance of the <see cref="NavigatorState"/> class.
    /// </summary>
    /// <param name="navigator">The navigator.</param>
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
    /// Called when this object is reinserted into the tree after having been removed via deactivate.
    /// </summary>
    public void Activate()
    {
    }

    /// <summary>
    /// Called when this object is removed from the tree.
    /// </summary>
    public void Deactivate()
    {
    }

    /// <summary>
    /// Users the gesture.
    /// </summary>
    /// <returns>A signal.</returns>
    public IObservable<Unit> UserGesture() => Observable.Return(Unit.Default);

    /// <summary>
    /// Complete the lifecycle for a route that has been popped off the navigator.
    /// </summary>
    /// <param name="route">The route.</param>
    public void FinalizeRoute([NotNull] Route route) => route.Dispose();

    /// <summary>
    /// Called when this object is inserted into the tree.
    /// </summary>
    public void InitializeState()
    {
        // TODO: [rlittlesii: August 13, 2022] Initialize the view model?
    }

    /// <summary>
    /// Pop the top-most route off the navigator.
    /// </summary>
    /// <typeparam name="T">The return type from the router.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<NavigationResult> Pop<T>()
        where T : Route => _navigator.Pop<T>().Select(_ => new NavigationResult());

    /// <summary>
    /// Pop the current route off the navigator and push a named route in its place.
    /// </summary>
    /// <param name="routeName">The route name.</param>
    /// <param name="argument">The argument.</param>
    /// <typeparam name="T">The route type.</typeparam>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PopAndPushNamed<T>(string routeName, object argument) => _navigator.PopAndPushNamed<T>(routeName, argument);

    /// <summary>
    /// Calls pop repeatedly until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<Unit> PopUntil<T>(Expression<Func<Route<T>, bool>> predicate) => _navigator.PopUntil<T>(predicate);

    /// <summary>
    /// Push the given route onto the navigator.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> Push<T>(Route<T> route) => _navigator.Push<T>(route);

    /// <summary>
    /// Push the given route onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <param name="predicate">The predicate.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PushAndRemoveUntil<T>(Route<T> route, Expression<Func<Route<T>, bool>> predicate) => _navigator.PushAndRemoveUntil(route, predicate);

    /// <summary>
    /// Push a named route onto the navigator.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PushNamed<T>(Route<T> route) => _navigator.PushNamed(route);

    /// <summary>
    /// Push the route with the given name onto the navigator, and then remove all the previous routes until the predicate returns true.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PushNamedAndRemoveUntil<T>(Route<T> route) => _navigator.PushNamedAndRemoveUntil(route).Select(_ => default(T)!);

    /// <summary>
    /// Replace the current route of the navigator by pushing the given route and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PushReplacement<T>(Route<T> route) => _navigator.PushReplacement(route);

    /// <summary>
    /// Replace the current route of the navigator by pushing the route named routeName and then disposing the previous route once the new route has finished animating in.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> PushReplacementNamed<T>(Route<T> route) => _navigator.PushReplacementNamed(route);

    /// <summary>
    /// Immediately remove route from the navigator, and Route.dispose it.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> RemoveRoute<T>(Route<T> route) => _navigator.RemoveRoute(route);

    /// <summary>
    /// Immediately remove a route from the navigator, and Route.dispose it. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> RemoveRouteBelow<T>(Route<T> route) => _navigator.RemoveRouteBelow(route);

    /// <summary>
    /// Replaces a route on the navigator with a new route.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> Replace<T>(Route<T> route) => _navigator.Replace(route);

    /// <summary>
    /// Replaces a route on the navigator with a new route. The route to be replaced is the one below the given anchorRoute.
    /// </summary>
    /// <typeparam name="T">The route type.</typeparam>
    /// <param name="route">The route.</param>
    /// <returns>An observable sequence of routes.</returns>
    public IObservable<T> ReplaceRouteBelow<T>(Route<T> route) => _navigator.ReplaceRouteBelow(route);
}