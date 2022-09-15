using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace Routing;

/// <summary>
/// Navigates to the specified routes.
/// </summary>
public class Router : IRouter
{
    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate(string url) =>
        Observable.Create<INavigationResult>(observer =>
        {
            if (string.IsNullOrEmpty(url))
            {
                observer.OnNext(new NavigationResult(false, new ArgumentNullException(nameof(url))));
                return Disposable.Empty;
            }

            observer.OnNext(new NavigationResult());
            observer.OnCompleted();
            return Disposable.Empty;
        });

    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate(string url, INavigationParameter navigationParameter)
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate<T>()
        where T : IViewModel
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate<T>(INavigationParameter navigationParameter)
        where T : IViewModel
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate<T>(string url)
        where T : IViewModel
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> Navigate<T>(string url, INavigationParameter navigationParameter)
        where T : IViewModel
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> GoBack(GoBackStrategy strategy)
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> GoBack(GoBackStrategy strategy, INavigationParameter navigationParameter)
    {
        return null;
    }

    /// <inheritdoc />
    public IObservable<INavigationResult> GoBackToRoot(INavigationParameter navigationParameter)
    {
        return null;
    }
}