using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Data;
using SpectrumAnalyser.Models.BD;


namespace SpectrumAnalyser.Controllers
{
    public class HomeController : Controller
    {
        EntityDataModel db = new EntityDataModel();
        public ActionResult Index()
        {
            ViewBag.Message = "Спектральный анализ.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "О программе.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Страница контактов.";

            return View();
        }
    }
}
