using MyWebProject.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.IRepository
{
    public class DrugRepository : IDrugRepository
    {
        public bool AddDrug(Drug returnRegister)
        {
            return true;
        }
        public bool ModifyDrug(Drug returnRegister)
        {
            return true;
        }
        public bool RemoveDrug(Drug returnRegister)
        {
            return true;
        }      

        public List<Drug> GetDrugs(string code)
        {
            throw new NotImplementedException();
        }
    }
}
