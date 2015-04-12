using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpectrumAnalyser.Controllers
{
    public class HistoryPeriodController : Controller
    {
        //
        // GET: /HistoryPeriod/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HistoryPeriod/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /HistoryPeriod/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /HistoryPeriod/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HistoryPeriod/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /HistoryPeriod/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /HistoryPeriod/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /HistoryPeriod/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
