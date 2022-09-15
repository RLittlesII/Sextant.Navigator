using System.Reactive;

namespace Routing;

/// <summary>
/// Represents the current navigation frame that can be animated.
/// </summary>
public interface IAnimated : IFrame
{
    /// <summary>
    /// Pops the top route of the navigation stack.
    /// </summary>
    /// <param name="animated">A value indicating whether to animate the navigation.</param>
    /// <returns>A <see cref="Unit"/> representing the result of the asynchronous operation.</returns>
    IObservable<IRoute> Pop(bool animated);

    /// <summary>
    /// Pops the to the root of the navigation stack.
    /// </summary>
    /// <param name="animated">A value indicating whether to animate the navigation.</param>
    /// <returns>A <see cref="Unit"/> representing the result of the asynchronous operation.</returns>
    IObservable<Unit> PopToRoot(bool animated);

    /// <summary>
    /// Pushes the route on to the stack.
    /// </summary>
    /// <param name="route">The route.</param>
    /// <param name="animated">A value indicating whether to animate the navigation.</param>
    /// <returns>A <see cref="Unit"/> representing the result of the asynchronous operation.</returns>
    IObservable<Unit> Push(IRoute route, bool animated);
}