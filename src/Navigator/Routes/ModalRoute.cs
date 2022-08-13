[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Generic type class.")]

namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/ModalRoute-class.html.
/// </summary>
/// <typeparam name="T">The argument type.</typeparam>
/// <seealso cref="TransitionRoute{T}" />
public class ModalRoute<T> : TransitionRoute<T>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ModalRoute{T}"/> class.
    /// </summary>
    /// <param name="routeSettings">The route settings.</param>
    protected ModalRoute(RouteSettings routeSettings)
        : base(routeSettings)
    {
    }

    /// <summary>
    /// Adds a scoped callback for when popped.
    /// </summary>
    /// <param name="callback">The call back.</param>
    public void AddScopedWillPopCallback([NotNull] Action callback) => callback.Invoke();
}