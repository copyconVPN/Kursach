using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class AccountingPointsController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Точки учета";
            ViewBag.AccountingPoints = db.AccountingPoints;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(AccountingPoints accountingpoints)
        {
            if (ModelState.IsValid)
            {
                db.AccountingPoints.Add(accountingpoints);
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

            var accountingpoints = db.AccountingPoints.Find(id);

            if (accountingpoints != null)
            {
                return PartialView("Edit", accountingpoints);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(AccountingPoints accountingpoints)
        {
            if (ModelState.IsValid)
            {
                db.Entry(accountingpoints).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var accountingpoints = db.AccountingPoints.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (accountingpoints != null)
            {
                return PartialView("Delete", accountingpoints);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var accountingpoints = db.AccountingPoints.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (accountingpoints != null)
            {
                db.AccountingPoints.Remove(accountingpoints);
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