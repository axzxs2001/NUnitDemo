using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebProject.Model.ViewModel;
using MyWebProject.Model.IRepository;

namespace MyWebProject.Controllers
{
    public class DrugController : Controller
    {
        IDrugRepository _drugRepository;
        public DrugController(IDrugRepository drugRepository)
        {
            _drugRepository = drugRepository;
        }

        [HttpGet("drugs")]
        public IActionResult Drugs()
        {
            return View();
        }

        [HttpGet("getdrugs")]
        public IActionResult GetDrugs()
        {
            try
            {
                var list = _drugRepository.GetDrugs();
                return new JsonResult(new { result = 1, message = $"添加drgu成功！", data = list });
            }
            catch (Exception exc)
            {
                return new JsonResult(new { result = 0, message = $"添加drgu错误：{exc.Message}" });
            }
        }

        [HttpPost("adddrug")]
        public JsonResult AddDrug(Drug drug)
        {
            try
            {
                _drugRepository.AddDrug(drug);
                return new JsonResult(new { result = 1, message = $"添加drgu成功！" });
            }
            catch (Exception exc)
            {
                return new JsonResult(new { result = 0, message = $"添加drgu错误：{exc.Message}" });
            }
        }
        [HttpPut("modifydrug")]
        public IActionResult ModifyDrug(Drug drug)
        {
            try
            {
                _drugRepository.ModifyDrug(drug);
                return new JsonResult(new { result = 1, message = $"修改drgu成功！" });
            }
            catch (Exception exc)
            {
                return new JsonResult(new { result = 0, message = $"修改drgu错误：{exc.Message}" });
            }
        }
        [HttpDelete("deletedrug")]
        public IActionResult RemoveDrug(string no)
        {
            try
            {
                _drugRepository.RemoveDrug(no);
                return new JsonResult(new { result = 1, message = $"删除drgu成功！" });
            }
            catch (Exception exc)
            {
                return new JsonResult(new { result = 0, message = $"删除drgu错误：{exc.Message}" });
            }
        }


    }
}
