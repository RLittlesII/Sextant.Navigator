using System.Reactive;

namespace Router;

public interface INavigated
{
    IObservable<Unit> NavigatedFrom(INavigationParameter navigationParameter);
    IObservable<Unit> NavigatedTo(INavigationParameter navigationParameter);
}