using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Xunit;

namespace Navigator.Tests
{
    public sealed class RouteTests
    {
        public class SettingsProperty
        {
            [Fact]
            public void Should()
            {
                var route = new Route(new RouteSettings {Name = "hello"});

                route.Settings.Name.Should().Be("hello");
            }
        }
    }
}
