namespace Sextant.Navigator
{
    /// <summary>
    /// An interface for objects that are aware of their current Route.
    /// This is used with RouteObserver to make a widget aware of changes to the Navigator's session history.
    /// </summary>
    /// <remarks>https://api.flutter.dev/flutter/widgets/RouteAware-class.html</remarks>
    public interface IRouteAware
    {
        void DidPop();
        void DidPopNext();
        void DidPush();
        void DidPushNext();
    }
}