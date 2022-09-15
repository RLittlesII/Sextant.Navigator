using Rocket.Surgery.Extensions.Testing.Fixtures;

namespace Routing.Tests;

internal sealed class TestRouteFixture : ITestFixtureBuilder
{
    public static implicit operator TestRoute(TestRouteFixture fixture) => fixture.Build();

    public TestRouteFixture WithUrl(string url) => this.With(ref _url, url);

    public TestRouteFixture WithViewModel(TestViewModel viewModel) => this.With(ref _viewModel, viewModel);

    private TestRoute Build() => new TestRoute(_url, _viewModel);

    private string _url;
    private TestViewModel _viewModel = new TestViewModel();
}