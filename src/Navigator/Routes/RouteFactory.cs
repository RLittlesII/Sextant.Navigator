namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/RouteFactory.html.
/// </summary>
public delegate Route RouteFactory(RouteSettings routeSettings);
public delegate Route<T> RouteFactory<T>(RouteSettings routeSettings);