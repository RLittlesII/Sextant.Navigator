namespace Routing;

/// <summary>
/// Interface representing events produced by the router.
/// </summary>
public interface IRoutingEvents
{
    /// <summary>
    /// Gets the routing event when an <see cref="IRoute"/> is popped.
    /// </summary>
    IObservable<RoutingEvent> PoppedEvents { get; }

    /// <summary>
    /// Gets the routing event when an <see cref="IRoute"/> is popped.
    /// </summary>
    IObservable<RoutingEvent> PoppedToRootEvents { get; }

    /// <summary>
    /// Gets the routing event when an <see cref="IRoute"/> is pushed.
    /// </summary>
    IObservable<RoutingEvent> PushedEvents { get; }
}