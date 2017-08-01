using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebProject.Model;
using System.Data.Common;

using System.Data.SqlClient;

namespace MyWebProject.Model.DbContext
{
    /// <summary>
    /// drug数据库操作类
    /// </summary>
    public class SqlDrugHandle : IDrugHandle
    {
        IDataHandle _dataHandle;
        public SqlDrugHandle(IDataHandle dataHandle)
        {
            _dataHandle = dataHandle;
        }
        public bool InsertDrug(Drug drug)
        {
            var sql = "insert inot drugs(no,name,quantity,price,placeorigin,memo) values(@no,@name,@quantity,@price,@placeorigin,@memo)";
            var noParmeter = new SqlParameter { ParameterName = "@no", Value = drug.No };
            var nameParmeter = new SqlParameter { ParameterName = "@name", Value = drug.Name };
            var quantityParmeter = new SqlParameter { ParameterName = "@quantity", Value = drug.Quantity };
            var priceParmeter = new SqlParameter { ParameterName = "@price", Value = drug.Price };
            var placeoriginParmeter = new SqlParameter { ParameterName = "@placeorigin", Value = drug.PlaceOrigin };
            var memoParmeter = new SqlParameter { ParameterName = "@memo", Value = drug.Memo };

            return _dataHandle.SavaChange(sql, noParmeter, nameParmeter, quantityParmeter, priceParmeter, placeoriginParmeter, memoParmeter);
        }

        public bool UpdateDrug(Drug drug)
        {
            var sql = "update drugs name=@name,quantity=@quantity,price=@price,placeorigin=@placeorigin,memo=@memo where no=@no";
            var noParmeter = new SqlParameter { ParameterName = "@no", Value = drug.No };
            var nameParmeter = new SqlParameter { ParameterName = "@name", Value = drug.Name };
            var quantityParmeter = new SqlParameter { ParameterName = "@quantity", Value = drug.Quantity };
            var priceParmeter = new SqlParameter { ParameterName = "@price", Value = drug.Price };
            var placeoriginParmeter = new SqlParameter { ParameterName = "@placeorigin", Value = drug.PlaceOrigin };
            var memoParmeter = new SqlParameter { ParameterName = "@memo", Value = drug.Memo };

            return _dataHandle.SavaChange(sql, noParmeter, nameParmeter, quantityParmeter, priceParmeter, placeoriginParmeter, memoParmeter);
        }

        public bool DeleteDrug(string no)
        {
            var sql = "delete drugs where no=@no";
            var noParmeter = new SqlParameter { ParameterName = "@no", Value = no };
            return _dataHandle.SavaChange(sql, noParmeter);
        }
        public Drug SelectDrug(string no)
        {
            var sql = "select * from drugs where no=@no";
            var noParmeter = new SqlParameter { ParameterName = "@no", Value = no };
            var table = _dataHandle.SelectTable(sql, noParmeter);
            if (table == null)
            {
                return null;
            }
            return new Drug { No = "" };
        }
        public List<Drug> SelectDrugs()
        {

            return new List<Drug>();
        }
    }
}
