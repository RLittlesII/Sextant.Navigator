using System.Reactive;

namespace Navigation;

public interface INavigationMediator
{
    IObservable<TResponse> Navigate<TResponse>(Uri uri)
        where TResponse : INavigationResponse;

    IObservable<INavigationResponse> Navigate<TRequest>(TRequest request)
        where TRequest : INavigationRequest;

    IObservable<INavigationResponse> Navigate<TViewModel>();

    IObservable<INavigationResponse> Navigate<TViewModel>(Uri uri);

    IObservable<INavigationResponse> Navigate<TViewModel>(INavigationRequest<TViewModel> request);
}

public interface INavigationResponse
{
    string CurrentUrl { get; }

    bool Successful { get; }

    Exception? Exception { get; }
}

public interface INavigationRequest : IDictionary<string, object>
{
    /// <summary>
    /// Gets the uri that will become the navigation stack.
    /// </summary>
    Uri Uri { get; }
}

public interface INavigationRequest<T> : INavigationRequest
{
    T ViewModel { get; }
}

public interface INavigationContext
{
}

public interface INavigationRequestHandler<TRequest, TResponse>
    where TRequest : INavigationRequest
    where TResponse : INavigationResponse
{
    IObservable<Unit> Initialize();
}