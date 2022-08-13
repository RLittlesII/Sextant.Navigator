using System.Collections.Immutable;

namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/TransitionDelegate-class.html.
/// </summary>
public delegate IImmutableList<RouteTransitionRecord> Resolve(
    List<RouteTransitionRecord> newPageRouteHistory,
    KeyValuePair<RouteTransitionRecord?, RouteTransitionRecord> locationToExitingPageRoute,
    KeyValuePair<RouteTransitionRecord?, List<RouteTransitionRecord>> pageRouteToPagelessRoutes);