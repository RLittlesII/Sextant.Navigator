using System;
using System.Reactive;
using System.Reactive.Linq;

namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/TransitionRoute-class.html
    /// </summary>
    public class TransitionRoute : Route
    {
        public TransitionRoute(RouteSettings routeSettings)
            : base(routeSettings)
        {
        }

        /// <summary>
        /// Gets the animation that drives the route's transition and the previous route's forward transition.
        /// </summary>
        public virtual Animation<double> Animation { get; }

        /// <summary>
        /// Gets a future that completes only once the transition itself has finished, after the overlay entries have been removed from the navigator's overlay. 
        /// </summary>
        public IObservable<Unit> Completed { get; }

        /// <summary>
        /// Gets a value indicating whether didPop calls NavigatorState.finalizeRoute. 
        /// </summary>
        public virtual bool FinishedWhenPopped { get; }

        /// <summary>
        /// Gets a value indicating whether the route obscures previous routes when the transition is complete.
        /// </summary>
        public bool Opaque { get; }

        /// <summary>
        /// Gets the time duration for a transition.
        /// </summary>
        public double TransitionDuration { get; protected set; }

        /// <summary>
        /// Returns true if previousRoute should animate when this route is pushed on top of it or when then this route is popped off of it.
        /// </summary>
        /// <param name="previousRoute">The previous route.</param>
        /// <returns>Whether the route can transition.</returns>
        public virtual bool CanTransitionFrom(TransitionRoute previousRoute) => true;

        /// <summary>
        /// Returns true if this route supports a transition animation that runs when nextRoute is pushed on top of it or when nextRoute is popped off of it.
        /// </summary>
        /// <param name="nextRoute">The next route.</param>
        /// <returns>Whether the route can transition.</returns>
        public virtual bool CanTransitionTo(TransitionRoute nextRoute) => true;

        /// <summary>
        /// Called to create the animation that exposes the current progress of the transition controlled by the animation controller created by createAnimationController().
        /// </summary>
        /// <returns>The animation.</returns>
        public virtual Animation<double> CreateAnimation() => default(Animation<double>);

        public virtual bool DidPop(object result) => true;
    }

    public class TransitionRoute<T> : TransitionRoute
    {
        public TransitionRoute(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }

        public new IObservable<T> Completed { get; }

        public virtual bool DidPop(T result) => true;
    }
}
