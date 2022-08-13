namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html.
/// </summary>
/// <typeparam name="T">The route type.</typeparam>
public class TransitionRoute<T> : Route<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransitionRoute"/> class.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    public TransitionRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }

    /// <summary>
    /// Gets the animation associated to the route.
    /// </summary>
    public virtual Animation<double> Animation { get; }

    /// <summary>
    /// Gets a notification when completed.
    /// </summary>
    public IObservable<Unit> Completed { get; }

    /// <summary>
    /// Gets the transition duration..
    /// </summary>
    public double TransitionDuration { get; }

    /// <summary>
    /// Gets a value indicating whether the route is finalized when popped.
    /// </summary>
    public bool FinishedWhenPopped { get; }

    /// <summary>
    /// Gets a value indicating whether gets a indicating whether or not the route is opaque.
    /// </summary>
    public bool Opaque { get; }

    /// <summary>
    /// A value indicating whether we can transition from the route.
    /// </summary>
    /// <param name="previousRoute">The previous route on the stack.</param>
    /// <returns>Whether or not the instance can transition.</returns>
    public bool CanTransitionFrom(TransitionRoute previousRoute) => true;

    /// <summary>
    /// A value indicating whether we can transition from the route.
    /// </summary>
    /// <param name="nextRoute">The next route on the stack.</param>
    /// <returns>Whether or not the instance can transition.</returns>
    public bool CanTransitionTo(TransitionRoute nextRoute) => true;

    /// <summary>
    /// Creates an animation.
    /// </summary>
    /// <returns>The animation.</returns>
    public Animation<double> CreateAnimation() => default(Animation<double>);
}

/// <summary>
/// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html.
/// </summary>
/// <typeparam name="T">The type.</typeparam>
public class TransitionRoute<T> : TransitionRoute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransitionRoute{T}"/> class.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    public TransitionRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }
}