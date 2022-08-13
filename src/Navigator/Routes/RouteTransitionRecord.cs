namespace Navigator.Routes;

/// <summary>
/// https://api.flutter.dev/flutter/widgets/RouteTransitionRecord-class.html.
/// </summary>
public class RouteTransitionRecord
{
    /// <summary>
    /// Gets the route.
    /// </summary>
    public Route Route { get; }

    /// <summary>
    /// Gets a value indicating whether whether this route is waiting for the decision on how to enter the screen.
    /// </summary>
    public bool IsWaitingForEnteringDecision { get; }

    /// <summary>
    /// Gets a value indicating whether whether this route is waiting for the decision on how to exit the screen.
    /// </summary>
    public bool IsWaitingForExitingDecision { get; }

    /// <summary>
    /// Marks the route to be added without transition.
    /// </summary>
    public void Add()
    {
    }

    /// <summary>
    /// Marks the route to be completed without transition.
    /// </summary>
    public void Complete()
    {
    }

    /// <summary>
    /// Marks the route to be popped with transition.
    /// </summary>
    public void Pop()
    {
    }

    /// <summary>
    /// Marks the route to be pushed with transition.
    /// </summary>
    public void Push()
    {
    }

    /// <summary>
    /// Marks the route to be removed without transition.
    /// </summary>
    public void Remove()
    {
    }
}