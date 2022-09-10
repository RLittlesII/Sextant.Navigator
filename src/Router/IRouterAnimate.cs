namespace Router;

public interface IRouterAnimate : IRouter
{
    /// <summary>
    /// Navigate to the specified <see cref="IViewModel"/>.
    /// </summary>
    /// <param name="navigationParameter">The navigation parameter.</param>
    /// <param name="animate">Animate the navigation.</param>
    /// <typeparam name="T">The view model type.</typeparam>
    /// <returns>A navigation result.</returns>
    IObservable<INavigationResult> Navigate<T>(INavigationParameter navigationParameter, bool animate)
        where T : INavigable;

    /// <summary>
    /// Navigate to the specified <see cref="IViewModel"/>.
    /// </summary>
    /// <param name="animate">Animate the navigation.</param>
    /// <typeparam name="T">The view model type.</typeparam>
    /// <returns>A navigation result.</returns>
    IObservable<INavigationResult> Navigate<T>(bool animate)
        where T : IViewModel;
}