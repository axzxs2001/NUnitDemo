using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyWebProject.Model.ViewModel;
namespace MyWebProject.Model.IRepository
{
    public interface IRegisterRepository
    {
        bool AddRegister(ReturnRegister returnRegister);
        bool UpdateRegister(ReturnRegister returnRegister);
        bool RemoveRegister(ReturnRegister returnRegister);
        List<ReturnRegister> GetRegisters(string code);
    }
}
