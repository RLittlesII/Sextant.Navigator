using Rocket.Surgery.Extensions.Testing.Fixtures;

namespace Routing.Tests;

internal sealed class RouterFixture : ITestFixtureBuilder
{
    public static implicit operator Router(RouterFixture fixture) => fixture.Build();

    private Router Build() => new Router();
}