using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.IDatahandle
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public class SqlDataHandle : IDataHandle
    {
        public DataTable SelectTable(string sql, params DbParameter[] parmeters)
        {
            throw new Exception();
        }

        public DataTable SelectValue(string sql, params DbParameter[] parmeters)
        {
            throw new Exception();
        }

        public bool SavaChange(string sql, params DbParameter[] parmeters)
        {
            return true;
        }

    }
}
