using System.Reactive;

namespace Routing;

/// <summary>
/// Represents the current navigation frame.
/// </summary>
public interface IFrame : IRoutingEvents
{
    /// <summary>
    /// Gets the list of routes on the stack.
    /// </summary>
    IReadOnlyList<IRoute> Routes { get; }

    /// <summary>
    /// Pops the top route of the navigation stack.
    /// </summary>
    /// <returns>A <see cref="Unit"/> representing the result of the asynchronous operation.</returns>
    IObservable<IRoute> Pop();

    /// <summary>
    /// Pops the to the root of the navigation stack.
    /// </summary>
    /// <returns>A <see cref="Unit"/> representing the result of the asynchronous operation.</returns>
    IObservable<Unit> PopToRoot();

    /// <summary>
    /// Pushes the route on to the stack.
    /// </summary>
    /// <param name="route">The route.</param>
    /// <returns>A <see cref="Task"/> representing the result of the asynchronous operation.</returns>
    IObservable<Unit> Push(IRoute route);
}