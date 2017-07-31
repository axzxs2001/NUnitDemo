using MyWebProject.Model.DbContext.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.DbContext
{
    public interface IRegister
    {
        bool InsertRegister(ReturnRegister returnResister);

        bool UpdateRegister(ReturnRegister returnResister);

        bool DeleteRegister(ReturnRegister returnResister);

        List<ReturnRegister> SelectRegisters();
    }
}
