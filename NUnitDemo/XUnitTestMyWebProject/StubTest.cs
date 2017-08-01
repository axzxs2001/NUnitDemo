using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace MyWebProjectTest
{
    [Trait("名称", "存根")]
    public class StubTest
    {
        /// <summary>
        /// 测试true返回值
        /// </summary>
        [Fact]
        public void IsValidLogFileName_NameExtension_ReturTurn()
        {
            //实例化存根
            var manger = new FakeExtensionManager();
            manger.WillbeValid = true;
            var log = new LogAnalyzer1(manger);
            //断言测试对象，非存根
            Assert.True(log.IsValidLogFileName("myfile.txt"));
        }
        /// <summary>
        /// 测试false返回值
        /// </summary>
        [Fact]
        public void IsValidLogFileName_NameExtension_ReturFalse()
        {
            //实例化存根
            var manger = new FakeExtensionManager();
            manger.WillbeValid = false;
            var log = new LogAnalyzer1(manger);
            //断言测试对象，非存根
            Assert.False(log.IsValidLogFileName("myfile.txt"));
        }
    }
    /// <summary>
    /// 被测试对象
    /// </summary>
    public class LogAnalyzer1
    {
        private IExtensionManager _manager;
        public LogAnalyzer1(IExtensionManager manager)
        {
            _manager = manager;
        }
        public bool IsValidLogFileName(string fileName)
        {
            return _manager.IsValid(fileName);
        }
    }
    /// <summary>
    /// 接口
    /// </summary>
    public interface IExtensionManager
    {
        bool IsValid(string fileName);
    }
    /// <summary>
    /// 存根对象
    /// </summary>
    public class FakeExtensionManager : IExtensionManager
    {
        public bool WillbeValid
        {
            get;
            set;
        } = false;
        public bool IsValid(string fileName)
        {
            return WillbeValid;
        }
    }
}
