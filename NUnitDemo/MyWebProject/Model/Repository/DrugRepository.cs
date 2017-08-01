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
        IDrugHandle _drugHandle;
        public DrugRepository(IDrugHandle drugHandle)
        {
            _drugHandle = drugHandle;
      
        }
        public bool AddDrug(Drug drug)
        {
            var dataDrug = Mapper.Map<DataModel.Drug>(drug);
            return _drugHandle.InsertDrug(dataDrug);
        }
        public bool ModifyDrug(Drug drug)
        {
            var dataDrug = Mapper.Map<DataModel.Drug>(drug);
            return _drugHandle.UpdateDrug(dataDrug);
        }
        public bool RemoveDrug(Drug drug)
        {
            var dataDrug = Mapper.Map<DataModel.Drug>(drug);
            return _drugHandle.DeleteDrug(dataDrug);
        }

        public List<Drug> GetDrugs(string code)
        {
            var drugList = _drugHandle.SelectDrugs();
            var drugs =new List<Drug>();
            Mapper.Map(drugList, drugs);
            return drugs;
        }
    }
}
