namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html
    /// </summary>
    public class RouteSettings
    {
        /// <summary>
        /// Gets the arguments passed to this route.
        /// </summary>
        public object Arguments { get; }

        /// <summary>
        /// Gets a value indicating whether this route is the very first route being pushed onto this Navigator.
        /// </summary>
        public bool IsInitialRoute { get; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }
    }

    public class RouteSettings<T> : RouteSettings
    {
        /// <summary>
        /// Gets the arguments passed to this route.
        /// </summary>
        public new T Arguments { get; }
    }
}
