using System.Reactive;

namespace Routing;

/// <summary>
/// Represents an item that can be initialized.
/// </summary>
public interface IInitializable
{
    /// <summary>
    /// Initializes the thing™.
    /// </summary>
    /// <param name="navigationParameter">The navigation parameters.</param>
    /// <returns>A completion signal.</returns>
    IObservable<Unit> Initializing(INavigationParameter navigationParameter);
}