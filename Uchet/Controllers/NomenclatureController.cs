using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class NomenclatureController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Номенклатура";
            ViewBag.Nomenclature = db.Nomenclature;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Nomenclature nomenclature)
        {
            if (ModelState.IsValid)
            {
                db.Nomenclature.Add(nomenclature);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            var nomenclature = db.Nomenclature.Find(id);

            if (nomenclature != null)
            {
                return PartialView("Edit", nomenclature);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Nomenclature nomenclature)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nomenclature).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var nomenclature = db.Nomenclature.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (nomenclature != null)
            {
                return PartialView("Delete", nomenclature);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var nomenclature = db.Nomenclature.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (nomenclature != null)
            {
                db.Nomenclature.Remove(nomenclature);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}