using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Uchet.Models;
using System.Data.Entity;

namespace Uchet.Controllers
{
    public class BuyerController : Controller
    {
        Context db = new Context();

        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Покупатели";
            ViewBag.Buyer = db.Buyer;
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return PartialView("Create");
        }

        [HttpPost]
        public ActionResult Create(Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                db.Buyer.Add(buyer);
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

            var buyer = db.Buyer.Find(id);

            if (buyer != null)
            {
                return PartialView("Edit", buyer);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Buyer buyer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(buyer).State = EntityState.Modified;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            var buyer = db.Buyer.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (buyer != null)
            {
                return PartialView("Delete", buyer);
            }
            return View("Index");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public ActionResult DeleteRecord(int? id)
        {
            var buyer = db.Buyer.Find(id);
            if (id == null)
            {
                return HttpNotFound();
            }
            if (buyer != null)
            {
                db.Buyer.Remove(buyer);
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