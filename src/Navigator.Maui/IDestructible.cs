namespace Navigator.Maui;

/// <summary>
/// Interface representing an element that needs to be destroyed.
/// </summary>
public interface IDestructible
{
    /// <summary>
    /// Tears down the instance.
    /// </summary>
    void Destroy();
}