using System.Reactive.Disposables;

namespace Navigator;

/// <summary>
/// Represents a disposable base class for easy clean up.
/// </summary>
public class DisposableBase : IDisposable
{
    /// <summary>
    /// Gets the disposables.
    /// </summary>
    protected CompositeDisposable Disposables { get; } = new CompositeDisposable();

    /// <inheritdoc/>
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    /// <summary>
    /// Disposes of this instances <see cref="CompositeDisposable"/>.
    /// </summary>
    /// <param name="disposing">A value indicating whether or not the instance is disposing.</param>
    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
        }
    }
}