using FluentAssertions;

namespace Routing.Tests;

public class RouterTests
{
    [Fact]
    public void GivenEmptyString_WhenNavigate_ThenNotSuccessful()
    {
        // Given
        Router sut = new RouterFixture();

        // When
        INavigationResult? result = null;
        using var _ = sut.Navigate("").Subscribe(navigation => result = navigation);

        // Then
        result.Succeeded.Should().BeFalse();
    }
}