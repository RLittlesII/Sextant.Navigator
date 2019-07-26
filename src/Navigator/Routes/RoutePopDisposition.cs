namespace Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/RoutePopDisposition-class.html
    /// </summary>
    public enum RoutePopDisposition
    {
        /// <summary>
        /// Delegate this to the next level of navigation.
        /// If Route.willPop return bubble then the back button will be handled by the SystemNavigator, which will usually close the application.
        /// </summary>
        Bubble = 2,

        /// <summary>
        /// Do not pop the route.
        /// If Route.willPop returns doNotPop then the back button will be ignored.
        /// </summary>
        DoNotPop = 1,

        /// <summary>
        /// Pop the route.
        /// If Route.willPop returns pop then the back button will actually pop the current route.
        /// </summary>
        Pop = 0,
    }
}
