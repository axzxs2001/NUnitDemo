using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext.DataModel
{
    /// <summary>
    /// 返回界面的实体类
    /// </summary>
    public class ReturnRegister
    {
        public string Code { get; set; }
        public string Data { get; set; }
        public string DataType { get; set; }
        public string Exception { get; set; }
        public string IsSuccess { get; set; }
        public string Message { get; set; } 
    }
}
