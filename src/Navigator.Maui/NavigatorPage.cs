using System.Reactive;
using System.Reactive.Linq;
using Microsoft.Maui.Controls;
using Routing;

namespace Navigator.Maui;

/// <summary>
/// A navigator page that implements <see cref="IFrame"/>.
/// </summary>
public class NavigatorPage : NavigationPage, IFrame
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NavigatorPage"/> class.
    /// </summary>
    public NavigatorPage()
    {
        Routes = Enumerable.Empty<IRoute>().ToList().AsReadOnly();
        PoppedEvents = Observable.FromEvent<EventHandler<NavigationEventArgs>, NavigationEventArgs>(
                eventHandler =>
                {
                    void Handler(object sender, NavigationEventArgs e) => eventHandler(e);
                    return Handler;
                },
                eventHandler => Popped += eventHandler,
                eventHandler => Popped -= eventHandler)
            .Select(args => null as RoutingEvent);

        PoppedToRootEvents = Observable.FromEvent<EventHandler<NavigationEventArgs>, NavigationEventArgs>(
                eventHandler =>
                {
                    void Handler(object sender, NavigationEventArgs e) => eventHandler(e);
                    return Handler;
                },
                eventHandler => PoppedToRoot += eventHandler,
                eventHandler => PoppedToRoot -= eventHandler)
            .Select(args => null as RoutingEvent);

        PushedEvents = Observable.FromEvent<EventHandler<NavigationEventArgs>, NavigationEventArgs>(
                eventHandler =>
                {
                    void Handler(object sender, NavigationEventArgs e) => eventHandler(e);
                    return Handler;
                },
                handler => Pushed += handler,
                handler => Pushed -= handler)
            .Select(args => null as RoutingEvent);
    }

    /// <inheritdoc/>
    public IObservable<RoutingEvent> PoppedEvents { get; }

    /// <inheritdoc/>
    public IObservable<RoutingEvent> PoppedToRootEvents { get; }

    /// <inheritdoc/>
    public IObservable<RoutingEvent> PushedEvents { get; }

    /// <inheritdoc/>
    public IReadOnlyList<IRoute> Routes { get; }

    /// <inheritdoc/>
    public IObservable<IRoute> Pop()
    {
        return null;
    }

    /// <inheritdoc/>
    public IObservable<Unit> PopToRoot()
    {
        return null;
    }

    /// <inheritdoc/>
    public IObservable<Unit> Push(IRoute route)
    {
        return null;
    }
}