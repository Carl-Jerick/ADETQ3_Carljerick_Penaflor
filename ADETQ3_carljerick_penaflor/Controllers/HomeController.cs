using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ADETQ3_CarlJerick_Penaflor.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("info");
        }

        public IActionResult Abt()
        {
            ViewData["Message"] = "Penaflor, Carl Jerick D.";
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}
