
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MyWebProject.Model
{
    /// <summary>
    /// 数据库操作
    /// </summary>
    public class SqlDataHandle : IDataHandle
    {
        ConnectionString _connectionString;
        public SqlDataHandle(IOptions<ConnectionString> options)
        {
            _connectionString = options.Value;
        }
        public DataTable SelectTable(string sql, params DbParameter[] parmeters)
        {
            using (var con = new SqlConnection(_connectionString.DefaultConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddRange(parmeters);
                var reader = cmd.ExecuteReader();
                //var table = new DataTable();
                return null;
            }
        }

        public object SelectValue(string sql, params DbParameter[] parmeters)
        {
            using (var con = new SqlConnection(_connectionString.DefaultConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddRange(parmeters);
                return cmd.ExecuteScalar();
            }
        }

        public bool SavaChange(string sql, params DbParameter[] parmeters)
        {
            using (var con = new SqlConnection(_connectionString.DefaultConnectionString))
            {
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.Parameters.AddRange(parmeters);
                var result = cmd.ExecuteNonQuery();
                return result > 0;
            }
        }

    }
}
