namespace Routing;

/// <summary>
/// Represents a modal router.
/// </summary>
public interface IModalRouter
{
    /// <summary>
    /// Navigates to a modal.
    /// </summary>
    /// <param name="animate">Animate the navigation.</param>
    /// <typeparam name="T">The view model type.</typeparam>
    /// <returns>A navigation result.</returns>
    IObservable<INavigationResult> NavigateToModal<T>(bool animate)
        where T : IViewModel;

    /// <summary>
    /// Pop modal.
    /// </summary>
    /// <param name="animate">Animate the navigation.</param>
    /// <returns>A navigation result.</returns>
    IObservable<INavigationResult> PopModal(bool animate);
}