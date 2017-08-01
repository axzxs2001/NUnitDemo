using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebProject.Model.ViewModel;
namespace MyWebProject.Model.IRepository
{
    /// <summary>
    /// drug仓储接口
    /// </summary>
    public interface IDrugRepository
    {
        /// <summary>
        /// 添加药品
        /// </summary>
        /// <param name="drug">药品</param>
        /// <returns></returns>
        bool AddDrug(Drug drug);
        /// <summary>
        /// 修改药品
        /// </summary>
        /// <param name="drug">药品</param>
        /// <returns></returns>
        bool ModifyDrug(Drug drug);
        /// <summary>
        /// 移除药品
        /// </summary>
        /// <param name="no">药品编号</param>
        /// <returns></returns>
        bool RemoveDrug(string no);
        /// <summary>
        /// 查询药品
        /// </summary>
        /// <returns></returns>
        List<Drug> GetDrugs();
    }
}
