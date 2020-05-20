using System;
using System.Linq.Expressions;
using System.Reactive.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;
using Navigator;
using NSubstitute;
using Sextant.Navigator;

namespace Navigator.Tests
{
    public sealed class NavigatorStateTests
    {
        public class TheNavigatorProperty
        {
            [Fact]
            public void Should_Return_Navigator()
            {
                // Given, When
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // Then
                sut.Navigator.Should().Be(navigator);
            }
        }

        public class ThePopMethod
        {
            [Fact]
            public async Task Should_Receive_Pop()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.Pop<Route<TestViewModel>>();

                // Then
                await navigator.Received().Pop<Route<TestViewModel>>();
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.Pop<Route<TestViewModel>>();

                // Then
                result.Should().BeOfType<Route<TestViewModel>>();
            }
        }

        public class ThePopAndPushNamedMethod
        {
            [Fact]
            public async Task Should_Receive_Pop_And_Push_Named()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PopAndPushNamed<Route<TestViewModel>>(string.Empty, default(object));

                // Then
                await navigator.Received().PopAndPushNamed<Route<TestViewModel>>(Arg.Any<string>(), Arg.Any<object>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result =
                    await sut.PopAndPushNamed<Route<TestViewModel>>(string.Empty, default(object));

                // Then
                result.Should().BeOfType<Route<TestViewModel>>();
            }
        }

        public class ThePopUntilMethod
        {
            [Fact]
            public async Task Should_Receive_Pop_Until()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PopUntil(Route.WithName<Route<TestViewModel>>("modal"));

                // Then
                await navigator.Received().PopUntil(Arg.Any<Expression<Func<Route<TestViewModel>, bool>>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.PopUntil(Route.WithName<Route<TestViewModel>>("modal"));

                // Then
                result.Should().BeOfType<Route<TestViewModel>>();
            }
        }

        public class ThePushMethod
        {
            [Fact]
            public async Task Should_Receive_Push()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.Push(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().Push(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.Push(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class ThePushAndRemoveUntilMethod
        {
            [Fact]
            public async Task Should_Receive_Push_And_Remove_Until()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PushAndRemoveUntil(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)), x => true);

                // Then
                await navigator.Received().PushAndRemoveUntil(Arg.Any<PageRoute<TestViewModel>>(),
                    Arg.Any<Expression<Func<PageRoute<TestViewModel>, bool>>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.PushAndRemoveUntil(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)),
                    Route.WithName<PageRoute<TestViewModel>>(""));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class ThePushNamedMethod
        {
            [Fact]
            public async Task Should_Receive_Push_Named()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PushNamed(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().PushNamed(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.PushNamed(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));


                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class ThePushReplacementMethod
        {
            [Fact]
            public async Task Should_Receive_Push_Replacement()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PushReplacement(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().PushReplacement(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.PushReplacement(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class ThePushReplacementNamedMethod
        {
            [Fact]
            public async Task Should_Receive_Push_Replacement_Named()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.PushReplacementNamed(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().PushReplacementNamed(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.PushReplacementNamed(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class TheRemoveRouteMethod
        {
            [Fact]
            public async Task Should_Receive_Remove_Route()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.RemoveRoute(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().RemoveRoute(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.RemoveRoute(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class TheRemoveRouteBelowMethod
        {
            [Fact]
            public async Task Should_Receive_Remove_Route()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.RemoveRouteBelow(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().RemoveRouteBelow(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.RemoveRouteBelow(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class TheReplaceMethod
        {
            [Fact]
            public async Task Should_Receive_Remove_Route()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.Replace(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().Replace(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.Replace(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }

        public class TheReplaceRouteBelowMethod
        {
            [Fact]
            public async Task Should_Receive_Remove_Route()
            {
                // Given
                var navigator = Substitute.For<INavigator>();
                NavigatorState sut = new NavigatorStateFixture().WithNavigator(navigator);

                // When
                await sut.ReplaceRouteBelow(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                await navigator.Received().ReplaceRouteBelow(Arg.Any<PageRoute<TestViewModel>>());
            }

            [Fact]
            public async Task Should_Return_Correct_Type()
            {
                // Given
                NavigatorState sut = new NavigatorStateFixture();

                // When
                var result = await sut.ReplaceRouteBelow(new PageRoute<TestViewModel>(new RouteSettings<TestViewModel>(string.Empty)));

                // Then
                result.Should().BeOfType<PageRoute<TestViewModel>>();
            }
        }
    }
}