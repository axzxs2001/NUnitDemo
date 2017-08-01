using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class DrugController : Controller
    {
        [HttpGet("drugs")]
        public IActionResult Drugs()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [HttpPost("adddrug")]
        public IActionResult AddDrug()
        {
            return View();
        }
        [HttpPut("modifydrug")]
        public IActionResult ModifyDrug()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        [HttpDelete("deletedrug")]
        public IActionResult RemoveDrug()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

      
    }
}
