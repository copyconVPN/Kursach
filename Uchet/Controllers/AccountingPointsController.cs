using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uchet.Controllers
{
    public class AccountingPointsController : Controller
    {
        // GET: AccountingPoints
        public ActionResult Index()
        {
            ViewBag.Message = "Точки учета";
            return View();
        }
    }
}