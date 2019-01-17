using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Uchet.Controllers
{
    public class ProfitController : Controller
    {
        // GET: Profit
        public ActionResult Index()
        {
            ViewBag.Message = "Поступления";
            return View();
        }
    }
}