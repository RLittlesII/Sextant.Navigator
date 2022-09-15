using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using Microsoft.Maui.Controls;
using Routing;

namespace Navigator.Maui;

/// <summary>
/// A navigator window that implements <see cref="IWindow"/>.
/// </summary>
public class NavigatorWindow : Window, IWindow
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NavigatorWindow"/> class.
    /// </summary>
    public NavigatorWindow()
    {
        Routes = Enumerable.Empty<IRoute>().ToList().AsReadOnly();

        PoppedEvents = Observable.FromEvent<EventHandler<ModalPoppedEventArgs>, ModalPoppedEventArgs>(
                eventHandler =>
                {
                    void Handler(object sender, ModalPoppedEventArgs e) => eventHandler(e);
                    return Handler;
                },
                x => ModalPopped += x,
                x => ModalPopped -= x)
            .Select(x => null as RoutingEvent);
        PoppedToRootEvents = Observable.Create<RoutingEvent>(_ => Disposable.Empty);
        PushedEvents = Observable.Create<RoutingEvent>(_ => Disposable.Empty);
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