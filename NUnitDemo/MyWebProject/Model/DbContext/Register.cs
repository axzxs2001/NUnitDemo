using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext
{
    public class Register : IRegister
    {
        public bool InsertRegister(ReturnRegister returnResister)
        {
            return true;
        }

        public bool UpdateRegister(ReturnRegister returnResister)
        {
            return true;
        }

        public bool DeleteRegister(ReturnRegister returnResister)
        {
            return true;
        }

        public List<ReturnRegister> SelectRegisters()
        {
            return new List<ReturnRegister>();
        }
    }
}
