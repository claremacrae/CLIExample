using System;
using System.Reflection.Metadata;
using Native;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(4, 4);
            Assert.Equal("Hello from C#", Class1.Hello());
        }
    }
}
