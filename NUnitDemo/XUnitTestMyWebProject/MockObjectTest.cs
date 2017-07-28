using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
namespace XUnitTestMyWebProject
{
    /// <summary>
    /// 模拟对象使用
    /// </summary>
    [Trait("名称", "模拟对象")]
    public class MockObjectTest
    {
        [Fact]
        public void Anlyze_ShowFileName_CallWebservice()
        {
            //模拟对象
            var mockService = new FakeWebService();
            var log = new LogAnalyzer(mockService);
            log.Analyze("abc.txt");
            //断言模拟对象
            Assert.Contains("FileName too short:", mockService.LastError);
        }
    }
    /// <summary>
    /// 被测试类
    /// </summary>
    public class LogAnalyzer
    {
        public IWebService _webService;
        public LogAnalyzer(IWebService webService)
        {
            _webService = webService;
        }

        public void Analyze(string fileName)
        {
            if(fileName.Length<8)
            {
                _webService.LogError("FileName too short:" + fileName);
            }
        }
    }
    /// <summary>
    /// web服务接口
    /// </summary>
    public interface IWebService
    {
        void LogError(string message);
    }
    /// <summary>
    /// Mock对象
    /// </summary>
    public class FakeWebService : IWebService
    {
        public string LastError
        { get; private set; }
        public void LogError(string message)
        {
            LastError = message;
        }
    }
}
