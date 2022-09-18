namespace Navigator.Maui;

/// <summary>
/// Interface representing a <see cref="NavigatorWindow"/> life cycle.
/// </summary>
public interface IWindowLifeCycle
{
    /// <summary>Occurs when the Window is created.</summary>
    void Created();

    /// <summary>
    /// Occurs when the Window is resumed from a sleeping state.
    /// </summary>
    void Resumed();

    /// <summary>Occurs when the Window is activated.</summary>
    void Activated();

    /// <summary>Occurs when the Window is deactivated.</summary>
    void Deactivated();

    /// <summary>Occurs when the Window is stopped.</summary>
    void Stopped();

    /// <summary>Occurs when the Window is destroyed.</summary>
    void Destroying();
}