using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstResponsiveWebAppTrainer.Models;

namespace FirstResponsiveWebAppTrainer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.year= DateTime.Now.Year;
            return View();
        }

        [HttpPost]
        public IActionResult Index(AgeModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Name =model.Name;
                ViewBag.AgeThisYear = model.AgeThisYear();
                ViewBag.AgeToday = model.AgeToday();
            }
            else
            {
                ViewBag.AgeThisYear = 0;
                ViewBag.AgeToday = 0;
            }
            ViewBag.year = DateTime.Now.Year;
            return View(model);
        }
    }
}
