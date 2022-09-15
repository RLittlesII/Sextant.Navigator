using FluentAssertions;

namespace Routing.Tests;

public class RouteTests
{
    [Fact]
    public void GivenNull_WhenConstructed_ThenThrowsException() =>

        // Given, When, Then
        Record
            .Exception(() => { TestRoute _ = new TestRouteFixture(); })
            .Should()
            .BeOfType<ArgumentNullException>();
}