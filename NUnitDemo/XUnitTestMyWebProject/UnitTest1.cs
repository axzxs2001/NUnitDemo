using System;
using Xunit;

namespace XUnitTestMyWebProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(10, add(4, 6));
        }

        int add(int a, int b)
        {
            return a + b;
        }
    }
}
