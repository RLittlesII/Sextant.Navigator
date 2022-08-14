using System.Reactive;

namespace Navigator.Tests;

/// <summary>
/// Mock instance of an <see cref="INavigator"/>.
/// </summary>
internal sealed class NavigatorMock : INavigator
{
    private readonly INavigator _navigator;

    /// <summary>
    /// Initializes a new instance of the <see cref="NavigatorMock"/> class.
    /// </summary>
    public NavigatorMock()
    {
        _navigator = Substitute.For<INavigator>();
        _navigator.Pop<Route<TestViewModel>>().Returns(_ => Observable.Return(new Route<TestViewModel>(new RouteSettings())));
        _navigator.PopAndPushNamed<Route<TestViewModel>>(Arg.Any<string>(), Arg.Any<object>()).Returns(_ => Observable.Return(new Route<TestViewModel>(new RouteSettings())));
        _navigator.PopUntil(Arg.Any<Expression<Func<Route<TestViewModel>, bool>>>()).Returns(_ => Observable.Return(new Route<TestViewModel>(new RouteSettings())));
        _navigator.Push(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.PushNamed(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.PushAndRemoveUntil(Arg.Any<PageRoute<TestViewModel>>(), Arg.Any<Expression<Func<PageRoute<TestViewModel>, bool>>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.PushReplacement(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.PushReplacementNamed(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.RemoveRoute(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.RemoveRouteBelow(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.Replace(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
        _navigator.ReplaceRouteBelow(Arg.Any<PageRoute<TestViewModel>>()).Returns(_ => Observable.Return(new PageRoute<TestViewModel>(new RouteSettings())));
    }

    /// <inheritdoc/>
    public string DefaultRouteName => nameof(NavigatorMock);

    /// <inheritdoc/>
    public RouteFactory OnGenerateRoute { get; set; } = settings => new Route(settings);

    public bool CanPop(INavigationContext context) => throw new NotImplementedException();

    /// <inheritdoc/>
    public List<string> Pages { get; }

    /// <inheritdoc/>
    public bool CanPop(INavigationContext context) => throw new NotImplementedException();

    /// <inheritdoc/>
    public IObservable<bool> MaybePop<TResult>(INavigationContext context)
        where TResult : class => _navigator.MaybePop<TResult>(context);

    /// <inheritdoc/>
    public IObservable<Unit> Pop<T>() => _navigator.Pop<T>();

    public IObservable<T> PopAndPushNamed<T>(string routeName, object argument)
        where T : Route => _navigator.PopAndPushNamed<T>(routeName, argument);

    /// <inheritdoc/>
    public IObservable<Unit> PopUntil<T>(Expression<Func<Route<T>, bool>> predicate) => _navigator.PopUntil(predicate);

    public IObservable<TRoute> Push<TRoute>(TRoute route)
        where TRoute : Route => _navigator.Push(route);

    public IObservable<TRoute> PushAndRemoveUntil<TRoute>(TRoute route, Expression<Func<TRoute, bool>> predicate)
        where TRoute : Route => _navigator.PushAndRemoveUntil(route, predicate);

    public IObservable<TRoute> PushNamed<TRoute>(TRoute route)
        where TRoute : Route => _navigator.PushNamed(route);

    public IObservable<TRoute> PushNamedAndRemoveUntil<TRoute>(TRoute route)
        where TRoute : Route => _navigator.PushNamedAndRemoveUntil(route);

    public IObservable<TRoute> PushReplacement<TRoute>(TRoute route)
        where TRoute : Route => _navigator.PushReplacement(route);

    public IObservable<TRoute> PushReplacementNamed<TRoute>(TRoute route)
        where TRoute : Route => _navigator.PushReplacementNamed(route);

    public IObservable<TRoute> RemoveRoute<TRoute>(TRoute route)
        where TRoute : Route => _navigator.RemoveRoute(route);

    public IObservable<TRoute> RemoveRouteBelow<TRoute>(TRoute route)
        where TRoute : Route => _navigator.RemoveRouteBelow(route);

    public IObservable<TRoute> Replace<TRoute>(TRoute route)
        where TRoute : Route => _navigator.Replace(route);

    public IObservable<TRoute> ReplaceRouteBelow<TRoute>(TRoute route)
        where TRoute : Route => _navigator.ReplaceRouteBelow(route);
}