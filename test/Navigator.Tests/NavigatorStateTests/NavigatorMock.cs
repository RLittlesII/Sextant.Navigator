namespace Navigator.Tests;

internal sealed class NavigatorMock : INavigator
{
    private readonly INavigator _navigator;

    public NavigatorMock()
    {
        _navigator = Substitute.For<INavigator>();
        _navigator.Pop<Route<TestViewModel>>().Returns(_ => Observable.Return(new Route<TestViewModel>(new RouteSettings())));
        _navigator.PopAndPushNamed<Route<TestViewModel>>(Arg.Any<string>(), Arg.Any<object>()).Returns(_ => Observable.Return(new Route<TestViewModel>( new RouteSettings())));
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

    public string DefaultRouteName => nameof(NavigatorMock);

    public RouteFactory OnGenerateRoute { get; set; }

    public bool CanPop(INavigationContext context) { throw new NotImplementedException(); }

    public IObservable<bool> MaybePop<TResult>(INavigationContext context)
        where TResult : class => _navigator.MaybePop<TResult>(context);

    public IObservable<T> Pop<T>()
        where T : Route => _navigator.Pop<T>();

    public IObservable<T> PopAndPushNamed<T>(string routeName, object argument) where T : Route =>
        _navigator.PopAndPushNamed<T>(routeName, argument);

    public IObservable<T> PopUntil<T>(Expression<Func<T, bool>> predicate) where T : Route => _navigator.PopUntil(predicate);

    public IObservable<T> Push<T>(T route) where T : Route => _navigator.Push(route);

    public IObservable<T> PushAndRemoveUntil<T>(T route, Expression<Func<T, bool>> predicate) where T : Route =>
        _navigator.PushAndRemoveUntil(route, predicate);

    public IObservable<T> PushNamed<T>(T route) where T : Route => _navigator.PushNamed(route);

    public IObservable<T> PushNamedAndRemoveUntil<T>(T route) where T : Route => _navigator.PushNamedAndRemoveUntil(route);

    public IObservable<T> PushReplacement<T>(T route) where T : Route => _navigator.PushReplacement(route);

    public IObservable<T> PushReplacementNamed<T>(T route) where T : Route => _navigator.PushReplacementNamed(route);

    public IObservable<T> RemoveRoute<T>(T route) where T : Route => _navigator.RemoveRoute(route);

    public IObservable<T> RemoveRouteBelow<T>(T route) where T : Route => _navigator.RemoveRouteBelow(route);

    public IObservable<T> Replace<T>(T route) where T : Route => _navigator.Replace(route);

    public IObservable<T> ReplaceRouteBelow<T>(T route) where T : Route => _navigator.ReplaceRouteBelow(route);
}