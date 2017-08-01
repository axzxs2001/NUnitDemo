using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext
{
    public interface IDrugHandle
    {
        bool InsertDrug(Drug drug);

        bool UpdateDrug(Drug drug);

        bool DeleteDrug(Drug drug);

        List<Drug> SelectDrugs();
    }
}
