using System.Collections.Generic;

namespace Sextant.Navigator
{
    /// <summary>
    /// https://api.flutter.dev/flutter/widgets/RouteSettings-class.html
    /// </summary>
    public class RouteSettings
    {
        public RouteSettings(string name, params object[] arguments)
        {
            Name = name;
            Arguments = arguments;
        }

        /// <summary>
        /// Gets the arguments passed to this route.
        /// </summary>
        public object[] Arguments { get; }

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
        public RouteSettings(string name, params T[] arguments)
            : base(name, arguments)
        {
            Arguments = arguments;
        }

        /// <summary>
        /// Gets the arguments passed to this route.
        /// </summary>
        public new IEnumerable<T> Arguments { get; }
    }
}
