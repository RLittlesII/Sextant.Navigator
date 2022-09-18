using System.Reactive;
using System.Reactive.Linq;

namespace Routing.Tests;

public class TestRoute : IRoute<TestViewModel>
{
    public TestRoute(string url, TestViewModel viewModel)
    {
        if (url is not { })
        {
            throw new ArgumentNullException(nameof(url));
        }

        Uri = new Uri(url);
        ViewModel = viewModel;
    }

    public TestViewModel ViewModel { get; }

    public Uri Uri { get; }
}

public class TestViewModel : INavigable
{
    /// <inheritdoc/>
    public IObservable<Unit> Initializing(INavigationParameter navigationParameter)
    {
        IsInitialized = true;
        return Observable.Return(Unit.Default);
    }

    /// <inheritdoc/>
    public IObservable<Unit> NavigatedFrom(INavigationParameter navigationParameter)
    {
        return Observable.Return(Unit.Default);
    }

    /// <inheritdoc/>
    public IObservable<Unit> NavigatedTo(INavigationParameter navigationParameter)
    {
        return Observable.Return(Unit.Default);
    }

    public bool IsInitialized { get; set; }
}