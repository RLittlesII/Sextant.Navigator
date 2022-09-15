namespace Routing;

/// <summary>
/// Creates routes.
/// </summary>
public interface IRouteFactory
{
    /// <summary>
    /// Create a <see cref="IRoute{T}"/>.
    /// </summary>
    /// <param name="url">The url.</param>
    /// <returns>The route.</returns>
    IRoute Create(string url);

    /// <summary>
    /// Create a <see cref="IRoute{T}"/>.
    /// </summary>
    /// <param name="url">The url.</param>
    /// <typeparam name="T">The view model type.</typeparam>
    /// <returns>The route.</returns>
    IRoute<T> Create<T>(string url);
}