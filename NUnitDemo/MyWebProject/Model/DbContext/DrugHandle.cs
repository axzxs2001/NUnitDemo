using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext
{
    public class DrugHandle : IDrugHandle
    {
        public bool InsertRegister(Drug returnResister)
        {
            return true;
        }

        public bool UpdateRegister(Drug returnResister)
        {
            return true;
        }

        public bool DeleteRegister(Drug returnResister)
        {
            return true;
        }

        public List<Drug> SelectRegisters()
        {
            return new List<Drug>();
        }
    }
}
