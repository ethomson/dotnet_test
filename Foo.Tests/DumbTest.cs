using System;
using Xunit;

using Foo.Core.Tests;

namespace Foo.Tests
{
    public class FooTests : TestBase
    {
        [Fact]
        public void Arithmetic()
        {
            Assert.Equal(42, 42);
        }
    }
}
