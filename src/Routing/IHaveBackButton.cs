namespace Routing;

/// <summary>
/// Interface representing a back button being pressed.
/// </summary>
public interface IHaveBackButton
{
    /// <summary>
    /// Gets a notification indicating whether the back button was pressed.
    /// </summary>
    IObservable<bool> BackButtonPressed { get; }
}