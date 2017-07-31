using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebProject.Model.ViewModel;
namespace MyWebProject.Model.IRepository
{
    public interface IDrugRepository
    {
        bool AddDrug(Drug returnRegister);
        bool ModifyDrug(Drug returnRegister);
        bool RemoveDrug(Drug returnRegister);
        List<Drug> GetDrugs(string code);
    }
}
