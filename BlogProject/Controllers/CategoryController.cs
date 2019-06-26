using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class CategoryController : Controller
    {
        [HttpGet]
        public IActionResult LifeStyle()
        {
            return View();
        }
        public IActionResult Health()
        {
            return View();
        }
        public IActionResult Family()
        {
            return View();
        }
        public IActionResult Management()
        {
            return View();
        }
        public IActionResult Travel()
        {
            return View();
        }
        public IActionResult Work()
        {
            return View();
        }
    }
}