using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace XUnitTestMyWebProject
{
    [Trait("名称", "隔离框架")]
    public class UnitTest2
    {
        [Fact]
        public void IsLength_FooString_ReturnTrue()
        {
            var mock = new Mock<IFoo>();
            mock.Setup(foo => foo.DoSomething("ping")).Returns(true);

            Assert.True(IsLength(mock.Object, "ping"));

        }
        [Fact]
        public void IsLength_FooIsNull_Throw()
        {
            var exception = Assert.Throws<Exception>(() => IsLength(null, null));
            Assert.Contains(exception.Message, "foo为空");

        }
        public bool IsLength(IFoo foo, string someString)
        {
            if (foo == null)
            {
                throw new Exception("foo为空");
            }
            else
            {
                return foo.DoSomething(someString);
            }
        }
    }

    public interface IFoo
    {
        Bar Bar { get; set; }
        string Name { get; set; }
        int Value { get; set; }
        bool DoSomething(string value);
        bool DoSomething(int number, string value);
        string DoSomethingStringy(string value);
        bool TryParse(string value, out string outputValue);
        bool Submit(ref Bar bar);
        int GetCount();
        bool Add(int value);
    }

    public class Bar
    {
        public virtual Baz Baz { get; set; }
        public virtual bool Submit() { return false; }
    }

    public class Baz
    {
        public virtual string Name { get; set; }
    }
}
