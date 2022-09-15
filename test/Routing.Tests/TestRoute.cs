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
    public IObservable<Unit> Initializing(INavigationParameter navigationParameter)
    {
        IsInitialized = true;
        return Observable.Return(Unit.Default);
    }

    public IObservable<Unit> NavigatedFrom(INavigationParameter navigationParameter)
    {
        return null;
    }

    public IObservable<Unit> NavigatedTo(INavigationParameter navigationParameter)
    {
        return null;
    }

    public bool IsInitialized { get; set; }
}