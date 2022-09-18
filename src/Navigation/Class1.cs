namespace Navigation;

public interface INavigationMediator
{
    IObservable<TResponse> Navigate<TRequest, TResponse>(TRequest request)
        where TRequest : INavigationRequest
        where TResponse : INavigationResponse;
}

public interface INavigationResponse
{
    string CurrentUrl { get; }

    bool Successful { get; }

    Exception? Exception { get; }
}

public interface INavigationRequest
{
}