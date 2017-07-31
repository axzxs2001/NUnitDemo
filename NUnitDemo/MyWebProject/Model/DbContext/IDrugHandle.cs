using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext
{
    public interface IDrugHandle
    {
        bool InsertRegister(Drug returnResister);

        bool UpdateRegister(Drug returnResister);

        bool DeleteRegister(Drug returnResister);

        List<Drug> SelectRegisters();
    }
}
