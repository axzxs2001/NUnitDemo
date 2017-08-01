using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;

namespace MyWebProjectTest
{
    /// <summary>
    /// 隔离模拟
    /// </summary>
    [Trait("名称", "隔离模拟")]
    public class BufferingTest
    {
        /// <summary>
        /// 测试true返回值
        /// </summary>
        [Fact]
        public void IsValidLogFileName_NameExtension_ReturTurn()
        {
            //实例化存根
            var manager = new Mock<IExtensionManager1>();
            manager.Setup(man => man.IsValid("myfile.txt")).Returns(true);
            var log = new LogAnalyzer2(manager.Object);
            //断言测试对象，非存根
            Assert.True(log.IsValidLogFileName("myfile.txt"));
        }

        /// <summary>
        /// 测试true返回值
        /// </summary>
        [Fact]
        public void SetString_InParmeter_ReturValue()
        {
            var time = DateTime.Now;
            //实例化存根
            var manager = new Mock<IExtensionManager1>();
            manager.Setup(man => man.SetString(It.IsAny<string>()))
        .Returns((string s) => s+ time);
            var log = new LogAnalyzer2(manager.Object);
            Console.WriteLine(time);
            //断言测试对象，非存根
            Assert.Equal($"123{time}abc", log.SetString("123"));
        }
    }

    /// <summary>
    /// 被测试对象
    /// </summary>
    public class LogAnalyzer2
    {
        private IExtensionManager1 _manager;
        public LogAnalyzer2(IExtensionManager1 manager)
        {
            _manager = manager;
        }
        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }

        public string SetString(string value)
        {
            return _manager.SetString(value) + "abc";
        }
    }
    /// <summary>
    /// 接口
    /// </summary>
    public interface IExtensionManager1
    {
        bool IsValid(string fileName);
        string SetString(string value);

    }

}
