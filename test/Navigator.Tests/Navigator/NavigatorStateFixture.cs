using ReactiveUI.Testing;
using Sextant.Navigator;

namespace Navigator.Tests
{
    internal sealed class NavigatorStateFixture : IBuilder
    {
        private INavigator _navigator;

        public NavigatorStateFixture()
        {
            _navigator = new NavigatorMock();
        }

        public NavigatorStateFixture WithNavigator(INavigator navigator) => this.With(ref _navigator, navigator);

        public static implicit operator NavigatorState(NavigatorStateFixture fixture) => fixture.Build();

        private NavigatorState Build() => new NavigatorState(_navigator);
    }
}