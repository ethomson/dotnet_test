using System;
using Xunit;

using Foo.Core;

namespace Foo.Core.Tests
{
    public class GreetingTest : TestBase
    {
        [Fact]
        public void GetGreeting()
        {
            Assert.Equal("hello, world", Greeting.GetMessage());
        }
    }
}
