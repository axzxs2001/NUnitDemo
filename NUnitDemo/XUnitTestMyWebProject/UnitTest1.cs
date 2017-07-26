using System;
using Xunit;

namespace XUnitTestMyWebProject
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10, 3, 7)]
        [InlineData(20, 11, 9)]
        public void Test1(int result, int a, int b)
        {
            Assert.Equal(result, add(a, b));
        }
        [Fact]
        public void Test2()
        {
            Assert.NotEqual(10, add(2, 3));
        }
        /// <summary>   
        /// �쳣����
        /// </summary>
        [Fact]       
        public void Test3()
        {
            var exc = Assert.Throws<DivideByZeroException>(() => abc());
          
            Assert.Contains("������Ϊ", exc.Message);
        }

        void abc()
        {
            throw new DivideByZeroException("������Ϊ0");
        }
        int add(int a, int b)
        {
            return a + b;
        }
    }
}
