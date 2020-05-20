using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Sextant.Navigator;
using Xunit;

namespace Navigator.Tests
{
    public sealed class RouteTests
    {
        public class SettingsProperty
        {
            [Fact]
            public void Should_Return_Name()
            {
                var route = new Route(new RouteSettings("hello" ));

                route.Settings.Name.Should().Be("hello");
            }
        }
    }
}
