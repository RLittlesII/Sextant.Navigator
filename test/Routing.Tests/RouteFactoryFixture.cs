using NSubstitute;
using ReactiveMarbles.Locator;
using Rocket.Surgery.Extensions.Testing.Fixtures;

namespace Routing.Tests;

internal sealed class RouteFactoryFixture : ITestFixtureBuilder
{
    public static implicit operator RouteFactory(RouteFactoryFixture fixture) => fixture.Build();

    public RouteFactoryFixture WithLocator(IServiceLocator locator) => this.With(ref _locator, locator);

    private RouteFactory Build() => new RouteFactory(_locator);

    private IServiceLocator _locator = Substitute.For<IServiceLocator>();
}