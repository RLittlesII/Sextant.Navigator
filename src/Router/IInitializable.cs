using System.Reactive;

namespace Router;

public interface IInitializable
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="navigationParameter"></param>
    /// <returns></returns>
    IObservable<Unit> Initializing(INavigationParameter navigationParameter);
}