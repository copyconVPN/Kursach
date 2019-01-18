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
            List<ProfitList> profitList = new List<ProfitList>();
            var loadDb = db.Profit;
            foreach (var item in loadDb)
            {
                profitList.Add(new ProfitList()
                {
                    Id = item.Id,
                    Nomenclature = db.Nomenclature.Find(item.Nomenclature).Name,
                    Date = item.Date,
                    Invoice = item.Invoice,
                    Provider = db.Providers.Find(item.Provider).Name,
                    AccountingPoint = db.AccountingPoints.Find(item.AccountingPoint).Name,
                    Quantity = item.Quantity,
                    Price = item.Price
                });
            }

            ViewBag.Profit = profitList;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var nomenclature = new List<object>();
            var i = 1;
            foreach (var item in db.Nomenclature.OrderBy(s => s.Name))
            {
                nomenclature.Add(new { key = i, label = item.Name });
                i++;
            }
            i = 1;
            var providers = new List<object>();
            foreach (var item in db.Providers.OrderBy(s => s.Name))
            {
                providers.Add(new { key = i, label = item.Name });
                i++;
            }
            i = 1;
            var accountingpoints = new List<object>();
            foreach (var item in db.AccountingPoints.OrderBy(s => s.Name))
            {
                accountingpoints.Add(new { key = i, label = item.Name });
                i++;
            }
            ViewBag.Nomenclature = new SelectList(nomenclature, "key", "label", null);
            ViewBag.Provider = new SelectList(providers, "key", "label", null);
            ViewBag.AccountingPoint = new SelectList(accountingpoints, "key", "label", null);
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