using System.Reactive;

namespace Routing;

/// <summary>
/// Represents and object navigated to and from.
/// </summary>
public interface INavigated
{
    /// <summary>
    /// Executed when the object is navigated from.
    /// </summary>
    /// <param name="navigationParameter">The navigation parameter.</param>
    /// <returns>A completion notification.</returns>
    IObservable<Unit> NavigatedFrom(INavigationParameter navigationParameter);

    /// <summary>
    /// Executed when the object is navigated to..
    /// </summary>
    /// <param name="navigationParameter">The navigation parameter.</param>
    /// <returns>A completion notification.</returns>
    IObservable<Unit> NavigatedTo(INavigationParameter navigationParameter);
}