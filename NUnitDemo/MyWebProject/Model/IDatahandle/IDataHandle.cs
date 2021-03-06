﻿
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public interface IDataHandle
    {
        DataTable SelectTable(string sql, params DbParameter[] parmeters);

        object SelectValue(string sql, params DbParameter[] parmeters);

        bool SavaChange(string sql, params DbParameter[] parmeters);

    }
}
