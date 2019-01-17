using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class ProvidersController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Поставщики";
            ViewBag.Providers = db.Providers;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {  
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Providers provider)
        {           
            if (ModelState.IsValid)
            {
                db.Providers.Add(provider);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit()
        {            
            ViewBag.Providers = db.Providers;
            return View();
        }

        [HttpPost]
        public ActionResult Edit(int id)
        {            
            ViewBag.Providers = db.Providers;
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var providers = db.Providers.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (providers != null)
            {
                return PartialView("Delete", providers);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var providers = db.Providers.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (providers != null)
            {
                db.Providers.Remove(providers);
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