namespace Routing;

public class RoutingException : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingException"/> class.
    /// </summary>
    public RoutingException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingException"/> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    public RoutingException(string message)
        : base(message)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="RoutingException"/> class.
    /// </summary>
    /// <param name="message">The exception message.</param>
    /// <param name="innerException">The exception.</param>
    public RoutingException(string message, Exception innerException)
        : base(message, innerException)
    {
    }
}