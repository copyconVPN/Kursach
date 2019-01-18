using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class ExpenseController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Расход";
            List<ExpenseList> expenseList = new List<ExpenseList>();
            var loadDb = db.Expense;
            foreach (var item in loadDb)
            {
                expenseList.Add(new ExpenseList()
                {
                    Id = item.Id,
                    Nomenclature = db.Nomenclature.Find(item.Nomenclature).Name,
                    Date = item.Date,
                    Invoice = item.Invoice,
                    ShippingAccountingPoint = db.AccountingPoints.Find(item.ShippingAccountingPoint).Name,
                    DeliveryAccountingPoint = db.AccountingPoints.Find(item.DeliveryAccountingPoint).Name,
                    Buyer = db.Buyer.Find(item.Buyer).Name,
                    Quantity = item.Quantity,
                    Price = item.Price
                });
            }

            ViewBag.Expense = expenseList;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var nomenclature = new List<object>();
            foreach (var item in db.Nomenclature.OrderBy(s => s.Name))
            {
                nomenclature.Add(new { key = item.Id, label = item.Name });
            }
            var accountingpoints = new List<object>();
            foreach (var item in db.AccountingPoints.OrderBy(s => s.Name))
            {
                accountingpoints.Add(new { key = item.Id, label = item.Name });
            }
            var buyer = new List<object>();
            foreach (var item in db.Buyer.OrderBy(s => s.Name))
            {
                buyer.Add(new { key = item.Id, label = item.Name });
            }
            ViewBag.Nomenclature = new SelectList(nomenclature, "key", "label", null);
            ViewBag.ShippingAccountingPoint = new SelectList(accountingpoints, "key", "label", null);
            ViewBag.DeliveryAccountingPoint = new SelectList(accountingpoints, "key", "label", null);
            ViewBag.Buyer = new SelectList(buyer, "key", "label", null);
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Expense expense)
        {
            if (ModelState.IsValid)
            {
                db.Expense.Add(expense);
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

            var expense = db.Expense.Find(id);

            if (expense != null)
            {
                return PartialView("Edit", expense);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Expense expense)
        {
            if (ModelState.IsValid)
            {
                db.Entry(expense).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var expense = db.Expense.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (expense != null)
            {
                return PartialView("Delete", expense);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var expense = db.Expense.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (expense != null)
            {
                db.Expense.Remove(expense);
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