using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyWebProject.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult AddRegister()
        {
            return View();
        }

        public IActionResult ModifyRegister()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult RemoveResister()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

      
    }
}
