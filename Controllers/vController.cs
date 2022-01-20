using Microsoft.AspNetCore.Mvc;
using MissionThree.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionThree.Controllers
{
    public class vController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult gradeCal()
        {
            return View();
        }
        [HttpPost]
        public IActionResult gradeCal(gradeCalModel model)
        {
            return View();
        }
    }
}
