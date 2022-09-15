using FluentAssertions;
using NSubstitute;
using ReactiveMarbles.Locator;

namespace Routing.Tests;

public class RouteFactoryTests
{
    [Fact]
    public void GivenUrl_WhenCreate_ThenInitialized()
    {
        // Given
        var locator = Substitute.For<IServiceLocator>();
        const string url = "/Page";
        TestRoute route = new TestRouteFixture().WithUrl(url);
        locator.GetService<IRoute<TestViewModel>>(Arg.Any<string>()).Returns(route);
        RouteFactory sut = new RouteFactoryFixture().WithLocator(locator);

        // When
        var result = sut.Create<TestViewModel>(url);

        // Then
        result
            .ViewModel
            .IsInitialized
            .Should()
            .BeTrue();
    }
}