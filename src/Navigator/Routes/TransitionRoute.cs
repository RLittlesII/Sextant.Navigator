using System;
using System.Reactive;

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

        public virtual Animation<double> Animation { get; }

        public IObservable<Unit> Completed { get; }

        public double TransitionDuration { get; }

        public bool FinishedWhenPopped { get; }

        public bool Opaque { get; }

        public bool CanTransitionFrom(TransitionRoute previousRoute) => true;

        public bool CanTransitionTo(TransitionRoute nextRoute) => true;

        public Animation<double> CreateAnimation() => default(Animation<double>);
    }

    public class TransitionRoute<T> : TransitionRoute
    {
        public TransitionRoute(RouteSettings<T> routeSettings)
            : base(routeSettings)
        {
        }

        public new IObservable<T> Completed { get; }
    }
}
