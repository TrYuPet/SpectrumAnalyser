using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Web.Mvc;
using SpectrumAnalyser.Models;
using WebMatrix.WebData;
using SpectrumAnalyser.Filters;
using Microsoft.Web.WebPages.OAuth;
using System.Transactions;
using SpectrumAnalyser.Models.BD;

namespace SpectrumAnalyser.Controllers
{

    public class AuthorPainterController : Controller
    {
        EntityDataModel db = new EntityDataModel();
       
        
        //
        // GET: /AuthorPainter/ListPainter
        public ActionResult ListPainter()
        {
            var painter = db.tbl_11_AuthorPictures.Include(p => p.tbl_13_HistoryPeriod).ToList();
            //var painter = db.tbl_11_Author_Painter.ToList();
            return View(painter);
        }


        //
        // GET: /AuthorPainter/ListWorkOfArt
        public ActionResult ListWorkOfArt(int id)
        {
            tbl_14_WorksOfArt art = db.tbl_14_WorksOfArt.Find(id);
            var art2 = db.tbl_14_WorksOfArt.Include(p => p.tbl_11_AuthorPictures).ToList();
            return View(art2);
        }
    }

        
}
