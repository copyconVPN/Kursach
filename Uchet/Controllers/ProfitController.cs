using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class ProfitController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Поступления";
            ViewBag.Profit = db.Profit;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Profit profit)
        {
            if (ModelState.IsValid)
            {
                db.Profit.Add(profit);
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

            var profit = db.Profit.Find(id);

            if (profit != null)
            {
                return PartialView("Edit", profit);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Profit profit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profit).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var profit = db.Profit.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (profit != null)
            {
                return PartialView("Delete", profit);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var profit = db.Profit.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (profit != null)
            {
                db.Profit.Remove(profit);
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