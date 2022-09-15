    namespace Routing;

    /// <summary>
    /// Represents the thing™ doing the routing.
    /// </summary>
    public interface IRouter
    {
        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate(string url);

        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate(string url, INavigationParameter navigationParameter);

        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate<T>()
            where T : IViewModel;

        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate<T>(INavigationParameter navigationParameter)
            where T : IViewModel;

        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate<T>(string url)
            where T : IViewModel;

        /// <summary>
        /// Navigate to the specified <see cref="IViewModel"/>.
        /// </summary>
        /// <param name="url">The url.</param>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <typeparam name="T">The view model type.</typeparam>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> Navigate<T>(string url, INavigationParameter navigationParameter)
            where T : IViewModel;

        /// <summary>
        /// Navigates to the most recent view model back by popping the navigation stack.
        /// </summary>
        /// <param name="strategy">The go back strategy.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBack(GoBackStrategy strategy);

        /// <summary>
        /// Navigates to the most recent view model back by popping the navigation stack.
        /// </summary>
        /// <param name="strategy">The go back strategy.</param>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBack(GoBackStrategy strategy, INavigationParameter navigationParameter);

        /// <summary>
        /// Navigates to the root view model popping all other view models.
        /// </summary>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBackToRoot(INavigationParameter navigationParameter);
    }