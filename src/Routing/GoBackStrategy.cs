namespace Routing;

/// <summary>
/// The strategy used for going back.
/// </summary>
public class GoBackStrategy : Enumeration<string>
{
    private GoBackStrategy(string value, string displayName)
        : base(value, displayName)
    {
    }

    /// <summary>
    /// Gets go back.
    /// </summary>
    public static GoBackStrategy GoBack { get; } = new GoBackStrategy("../", "Go Back");

    /// <summary>
    /// Gets skip a page while going back.
    /// </summary>
    public static GoBackStrategy SkipAndGoBack { get; } = new GoBackStrategy("../", "Skip and Go Back");

    /// <summary>
    /// Gets go back and replace the current page with the provided page.
    /// </summary>
    public static GoBackStrategy ReplaceAndGoBack { get; } = new GoBackStrategy("../", "Go Back");
}