using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.MaintainabilityRules", "SA1402:File may only contain a single type", Justification = "Generic")]

namespace Router;

/// <summary>
/// Represents an untyped route.
/// </summary>
public interface IRoute : IRoute<object>
{
}

/// <summary>
/// Represents an type constrained route.
/// </summary>
/// <typeparam name="T">The route type.</typeparam>
public interface IRoute<T>
{
    /// <summary>
    /// Gets the view model associated with the route.
    /// </summary>
    T ViewModel { get; }

    /// <summary>
    /// Gets the uri representation of the route.
    /// </summary>
    Uri Uri { get; }
}