using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using SpectrumAnalyser.Models;
using SpectrumAnalyser.Models.BD;
using WebMatrix.WebData;
using SpectrumAnalyser.Filters;
using Microsoft.Web.WebPages.OAuth;
using System.Transactions;
using SpectrumAnalyser.Helpers;

namespace SpectrumAnalyser.Controllers
{
    public class SideMenuController : Controller
    {
        private EntityDataModel db = new EntityDataModel();
        //
        // GET: /SideMenu/

        public ActionResult Items()
        {
            //var painter = db.tbl_11_Author_Painter.Include(p => p.tbl_13_History_Period).ToList();
            //var item = db.tbl_13_History_Period.Include(p => p.tbl_11_Author_Painter).ToList();
            return View(SideMenuHelper.GetItemList());
        }


        
         //GET: /SideMenu/Details/5

        public ActionResult Details(int id)
        {
            //tbl_11_Author_Painter painter = db.tbl_11_Author_Painter.Find(id);
            //var apainter = db.tbl_14_Works_of_art.Include(p => p.tbl_11_Author_Painter).ToList();            
            var apainter = db.tbl_11_AuthorPictures.Include(p => p.tbl_13_HistoryPeriod).ToList();
            List<tbl_11_AuthorPictures> listpainter = new List<tbl_11_AuthorPictures>();
            foreach (var painter in apainter)
            {
                if (painter.HistoryPeriodId == id)
                {
                    listpainter.Add(painter);
                }
            }
            return View(listpainter);
        }

        
         //GET: /SideMenu/Create

        public ActionResult WorksList(int id)
        {
            var pict = db.tbl_14_WorksOfArt.Include(p => p.tbl_11_AuthorPictures).ToList();
            List<tbl_14_WorksOfArt> listpict = new List<tbl_14_WorksOfArt>();
            foreach (var painter in pict)
            {
                if (painter.AuthorPicturesId == id)
                {
                    listpict.Add(painter);
                }
            }
            return View(listpict);
        }

        //
        // POST: /SideMenu/Create

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
    }
}
