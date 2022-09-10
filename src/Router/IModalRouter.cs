namespace Router;

public interface IModalRouter
{
    IObservable<INavigationResult> NavigateToModal<T>(bool animate)
        where T : IViewModel;

    IObservable<INavigationResult> PopModal(bool animate);
}