namespace Router;

public interface INavigationResult
{
    bool Succeeded { get; }

    Exception? Exception { get; }
}