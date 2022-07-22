using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryApp.Controllers
{
    public class välilehti1 : Controller
    {
        public IActionResult Index()
        {
            return View();

        }

        public IActionResult KurssiListaus()
        {
            ViewData["ID"] = 3;
            return View();
        }
    }
}
