using MyWebProject.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebProject.Model.IRepository
{
    public class RegisterRepository : IRegisterRepository
    {
        public bool AddRegister(ReturnRegister returnRegister)
        {
            return true;
        }
        public bool UpdateRegister(ReturnRegister returnRegister)
        {
            return true;
        }
        public bool RemoveRegister(ReturnRegister returnRegister)
        {
            return true;
        }
        public  List<ReturnRegister> GetRegisters(string code)
        {
            return null;
        }
    }
}
