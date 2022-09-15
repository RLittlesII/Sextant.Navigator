using System.Reactive;
using Routing;

namespace Navigator.Maui;

/// <summary>
/// Inerface representing life cycle events for <see cref="IFrame"/>.
/// </summary>
public interface IFrameLifeCycle
{
    /// <summary>
    /// Gets a notification when the frame is appearing.
    /// </summary>
    IObservable<Unit> Appearing { get; }

    /// <summary>
    /// Gets a notification when the frame is disappearing.
    /// </summary>
    IObservable<Unit> Disappearing { get; }
}