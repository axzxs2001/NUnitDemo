using AutoMapper;
using MyWebProject.Model.DbContext;
using MyWebProject.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModel = MyWebProject.Model.DbContext.DataModel;
namespace MyWebProject.Model.IRepository
{
    /// <summary>
    /// drug仓储类
    /// </summary>
    public class DrugRepository : IDrugRepository
    {
        /// <summary>
        /// 药品数据操作对象
        /// </summary>
        IDrugHandle _drugHandle;
        /// <summary>
        /// 实例化仓储对象
        /// </summary>
        /// <param name="drugHandle">药品数据操作对象</param>
        public DrugRepository(IDrugHandle drugHandle)
        {
            _drugHandle = drugHandle;

        }
        /// <summary>
        /// 添加药品
        /// </summary>
        /// <param name="drug">药品</param>
        /// <returns></returns>
        public bool AddDrug(Drug drug)
        {
            if (drug == null)
            {
                throw new Exception("drug为空!");
            }
            if (string.IsNullOrEmpty(drug.Name))
            {
                throw new Exception("drug属性name不能为空");
            }
            if (drug.Quantity <= 0)
            {
                throw new Exception("drug属性数量不能小于0");
            }
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Drug,DataModel.Drug>();
            });
            var dataDrug = Mapper.Map<DataModel.Drug>(drug);
            return _drugHandle.InsertDrug(dataDrug);
        }
        /// <summary>
        /// 修改药品
        /// </summary>
        /// <param name="drug">药品</param>
        /// <returns></returns>
        public bool ModifyDrug(Drug drug)
        {
            if (drug == null)
            {
                throw new Exception("drug为空");
            }
            if (string.IsNullOrEmpty(drug.No))
            {
                throw new Exception("drug属性no不能为空");
            }
            else
            {
                var selectDrug = _drugHandle.SelectDrug(drug.No);
                if (selectDrug == null)
                {
                    throw new Exception($"no={drug.No}的，drug不存在");
                }
            }
            if (string.IsNullOrEmpty(drug.Name))
            {
                throw new Exception("drug属性name不能为空");
            }
            if (drug.Quantity <= 0)
            {
                throw new Exception("drug属性数量不能小于0");
            }
            var dataDrug = Mapper.Map<DataModel.Drug>(drug);
            return _drugHandle.UpdateDrug(dataDrug);
        }
        /// <summary>
        /// 移除药品
        /// </summary>
        /// <param name="no">药品编号</param>
        /// <returns></returns>
        public bool RemoveDrug(string no)
        {
            if (string.IsNullOrEmpty(no))
            {
                throw new Exception("drug属性no不能为空");
            }
            return _drugHandle.DeleteDrug(no);
        }
        /// <summary>
        /// 查询药品
        /// </summary>
        /// <returns></returns>
        public List<Drug> GetDrugs()
        {
            var drugList = _drugHandle.SelectDrugs();
            var drugs = new List<Drug>();
            if (drugList == null || drugList.Count == 0)
            {
                return drugs;
            }
            else
            {
                Mapper.Map(drugList, drugs);
                return drugs;
            }
        }
    }
}
