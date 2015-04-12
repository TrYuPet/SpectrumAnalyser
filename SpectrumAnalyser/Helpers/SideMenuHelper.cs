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
using SpectrumAnalyser.Models.DataModel;

namespace SpectrumAnalyser.Helpers
{
    public static class SideMenuHelper
    {
        private static EntityDataModel db = new EntityDataModel();
        public static PainterModel GetItemList()
        {
            PainterModel pm = new PainterModel();
            var item = db.tbl_13_HistoryPeriod.Include(p => p.tbl_11_AuthorPictures).ToList();
            pm.HistoryPeriod = item;

            var apainter = db.tbl_14_WorksOfArt.Include(p => p.tbl_11_AuthorPictures).ToList();
            pm.AuthorPainter = apainter;

            return pm;
        }

    }
}