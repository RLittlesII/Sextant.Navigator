namespace Navigator.Tests;

internal sealed class NavigatorStateFixture : ITestFixtureBuilder
{
    private INavigator _navigator;

    public NavigatorStateFixture()
    {
        _navigator = new NavigatorMock();
    }

    public static implicit operator NavigatorState(NavigatorStateFixture fixture) => fixture.Build();

    public NavigatorStateFixture WithNavigator(INavigator navigator) => this.With(ref _navigator, navigator);

    private NavigatorState Build() => new NavigatorState(_navigator);
}