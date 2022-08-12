[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Generic type class.")]

namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html.
/// </summary>
public class RouteSettings
{
    /// <summary>
    /// Gets the arguments passed to this route.
    /// </summary>
    public object Arguments { get; }

    /// <summary>
    /// Gets a value indicating whether this route is the very first route being pushed onto this Navigator.
    /// </summary>
    public bool IsInitialRoute { get; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    public string Name { get; set; }
}

/// <summary>
/// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html.
/// </summary>
/// <typeparam name="T">The argument type.</typeparam>
public class RouteSettings<T> : RouteSettings
{
    /// <summary>
    /// Gets the arguments passed to this route.
    /// </summary>
    public new T Arguments { get; }
}