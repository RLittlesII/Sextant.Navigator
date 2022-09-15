using System.Diagnostics.CodeAnalysis;
using ReactiveMarbles.Locator;
using static Routing.NavigationFunctions;

[assembly: SuppressMessage("StyleCop.CSharp.NamingRules", "SA1312:Variable names should begin with lower-case letter", Justification = "Privates at the bottom.")]

namespace Routing;

/// <summary>
/// Factory for creating routes.
/// </summary>
public class RouteFactory : IRouteFactory
{
    private readonly IServiceLocator _locator;

    /// <summary>
    /// Initializes a new instance of the <see cref="RouteFactory"/> class.
    /// </summary>
    /// <param name="locator">The service locator.</param>
    public RouteFactory(IServiceLocator locator)
    {
        _locator = locator;
    }

    /// <inheritdoc/>
    public IRoute Create(string url)
    {
        var route = _locator.GetService<IRoute>(url);

        Initialize(route.ViewModel);

        return route;
    }

    /// <inheritdoc />
    public IRoute<T> Create<T>(string url)
    {
        var route = _locator.GetService<IRoute<T>>(url);

        Initialize(route.ViewModel);

        return route;
    }
}