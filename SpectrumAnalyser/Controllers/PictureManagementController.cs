using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpectrumAnalyser.Models.BD;
using System.IO;

namespace SpectrumAnalyser.Controllers
{
    public class PictureManagementController : Controller
    {
        private EntityDataModel samdb = new EntityDataModel();
        //
        // GET: /PictureManagement/

        public ActionResult Index()
        {
            return View(samdb.tbl_14_WorksOfArt);
        }

        //
        // GET: /PictureManagement/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /PictureManagement/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PictureManagement/Create

        //[HttpGet]
        public ActionResult AddPicture(tbl_14_WorksOfArt pict, HttpPostedFileBase uploadImage)
        {
            if (ModelState.IsValid && uploadImage != null)
            {
                byte[] imageData = null;
                // считываем переданный файл в массив байтов
                using (var binaryReader = new BinaryReader(uploadImage.InputStream))
                {
                    imageData = binaryReader.ReadBytes(uploadImage.ContentLength);
                }
                // установка массива байтов
                pict.PicturePhoto = imageData;

                samdb.tbl_14_WorksOfArt.Add(pict);
                samdb.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(pict);

        }

        //
        // GET: /PictureManagement/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /PictureManagement/Edit/5

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
        // GET: /PictureManagement/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /PictureManagement/Delete/5

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
