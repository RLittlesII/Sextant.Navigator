    namespace Router;

    /// <summary>
    /// Represents the thing™ doing the routing.
    /// </summary>
    public interface IRouter
    {
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
        /// Navigates to the most recent view model back by popping the navigation stack.
        /// </summary>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBack();

        /// <summary>
        /// Navigates to the most recent view model back by popping the navigation stack.
        /// </summary>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBack(INavigationParameter navigationParameter);

        /// <summary>
        /// Navigates to the root view model popping all other view models.
        /// </summary>
        /// <param name="navigationParameter">The navigation parameter.</param>
        /// <returns>A navigation result.</returns>
        IObservable<INavigationResult> GoBackToRoot(INavigationParameter navigationParameter);
    }

    // TODO: [rlittlesii: December 30, 2020] Not sure if I want a Prism style navigation result, or allow the service to return a value like MVVMCross, maybe both?